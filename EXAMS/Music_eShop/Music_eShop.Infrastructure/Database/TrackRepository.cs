﻿using Dapper;
using Microsoft.Data.Sqlite;
using Music_eShop.Domain.Models;
using Music_eShop.Infrastructure.Interfaces;
using System.Text;

namespace Music_eShop.Infrastructure.Database
{
    public class TrackRepository : ITrackRepository
    {
        private readonly ChinookContext _context;

        public TrackRepository() { }

        public TrackRepository(ChinookContext context)
        {
            _context = context;
        }

        public List<Track> GetTracksSortedByNameAsc()
        {
            return (from t in _context.Tracks
                    where t.Status == "Active"
                    select t).OrderBy(t => t.Name)
                             .ToList();
        }

        public List<Track> GetTracksSortedByNameDesc()
        {
            return (from t in _context.Tracks
                    select t).OrderByDescending(t => t.Name)
                             .ToList();
        }

        public List<Track> GetTracksSortedByComposer()
        {
            return (from t in _context.Tracks
                    orderby t.Composer//, t.Album
                    select t).ToList();
        }

        public List<Track> GetTracksSortedByGenre()
        {
            return _context.Tracks.OrderBy(t => t.Genre).ToList();
        }

        public List<Track> GetTracksSortedByComposerAndAlbum()
        {
            return _context.Tracks.OrderBy(t => t.Composer).ThenBy(t => t.Album).ToList();
        }

        public List<Track> FindTracksById(string searchText)
        {
            if (!long.TryParse(searchText, out long id)) return new List<Track>();

            return (from t in _context.Tracks
                    where t.TrackId == id
                    select t).ToList();
        }

        public List<Track> FindTracksByName(string searchText)
        {
            return _context.Tracks
                           .Where(t => t.Name.Contains(searchText))
                           .ToList();
        }

        public List<Track> FindTracksByComposer(string searchText)
        {
            return _context.Tracks
                           .Where(t => t.Composer.Contains(searchText))
                           .ToList();
        }

        public List<Track> FindTracksByGenre(string searchText)
        {
            return _context.Tracks
                           .Where(t => t.Genre.Name.Contains(searchText))
                           .ToList();
        }

        public List<Track> FindTracksByComposerAndAlbum(string searchText)
        {
            var foundComposers = _context.Tracks
                                     .Where(t => t.Composer.Contains(searchText))
                                     .ToList();

            var foundAlbums = _context.Tracks
                                      .Where(t => t.Album.Title.Contains(searchText))
                                      .ToList();

            var foundComposersAndAlbums = new List<Track>();
            foundComposersAndAlbums.AddRange(foundComposers);
            foundComposersAndAlbums.AddRange(foundAlbums);

            return foundComposersAndAlbums;
        }

        public List<Track> FindTracksByMilliseconds(string from, string to)
        {
            if (!long.TryParse(from, out long milliFrom)) return new List<Track>();
            if (!long.TryParse(to, out long milliTo)) return new List<Track>();

            return _context.Tracks
                           .Where(t => t.Milliseconds >= milliFrom && t.Milliseconds <= milliTo)
                           .ToList();
        }

        public List<Track> FindTracksByAlbumAndArtist(string searchText)
        {
            var foundAlbums = _context.Tracks
                                      .Where(t => t.Album.Title.Contains(searchText))
                                      .ToList();

            var foundArtists = _context.Tracks
                                       .Where(t => t.Album.Artist.Name.Contains(searchText))
                                       .ToList();

            var foundAlbumsAndArtists = new List<Track>();
            foundAlbumsAndArtists.AddRange(foundAlbums);
            foundAlbumsAndArtists.AddRange(foundArtists);

            return foundAlbumsAndArtists;
        }

        public void Print(List<Track> tracks)
        {
            string albumTitle = "";
            string genreName = "";
            string composer = "";

            //Console.WriteLine($"{"Id",-4} {"Name",-45} {"Composer",-45} {"Album",-35} {"Genre",-20}");
            Console.WriteLine();
            Console.WriteLine("┌────┬─────────────────────────────────────────────┬─────────────────────────────────────────────┬───────────────────────────────────┬────────────────────┬──────────┬──────────┐");
            Console.WriteLine($"│{"Id",-4}│{"Name",-45}│{"Composer",-45}│{"Album",-35}│{"Genre",-20}│{"Millisec",-10}│{"Price",-10}│");
            Console.WriteLine("├────┼─────────────────────────────────────────────┼─────────────────────────────────────────────┼───────────────────────────────────┼────────────────────┼──────────┼──────────┤");


            foreach (var track in tracks)
            {
                if (track.AlbumId != null) albumTitle = track.Album.Title;
                if (track.GenreId != null) genreName = track.Genre.Name;
                if (track.Composer != null) composer = track.Composer;

                Console.WriteLine($"│{track.TrackId,-4}│{track.Name.Truncate(44),-45}│{composer.Truncate(44),-45}│{albumTitle.Truncate(34),-35}│{genreName.Truncate(19),-20}│{track.Milliseconds.ToString().Truncate(9),-10}│{Encoding.Default.GetString(track.UnitPrice).Truncate(9),-10}│");
                //Console.WriteLine($"{track.TrackId,-4} {track.Name,-45} {composer,-45} {albumTitle,-35} {genreName,-20}");
                //Console.WriteLine($"{track.TrackId,4} - {track.Name} - {composer} - {albumTitle} - {genreName} - {track.Milliseconds} - {Encoding.Default.GetString(track.UnitPrice)}");
            }
            Console.WriteLine("└────┴─────────────────────────────────────────────┴─────────────────────────────────────────────┴───────────────────────────────────┴────────────────────┴──────────┴──────────┘");
        }

        public Track? Get(string trackId)
        {
            long id = 0;
            while (!long.TryParse(trackId, out id))
            {
                Console.Write("Blogas pasirinkimas, bandykite dar kartą: ");
                trackId = Console.ReadLine();
            }
            var track = new Track();

            if (!_context.Tracks.Any()) return track;

            return (from t in _context.Tracks
                    where t.TrackId == id
                    select t).FirstOrDefault();
        }

        public Track ChangeStatus(string trackId)
        {
            long id = 0;
            while (!long.TryParse(trackId, out id))
            {
                Console.Write("Blogas pasirinkimas, bandykite dar kartą: ");
                trackId = Console.ReadLine();
            }
            
            var track = (from t in _context.Tracks
                    where t.TrackId == id
                    select t).FirstOrDefault();

            if (track.Status == "Active")
                track.Status = "Inactive";
            else
                track.Status = "Active";

            _context.SaveChanges();

            return track;
        }
    }
    public static class StringExt
    {
        public static string? Truncate(this string? value, int maxLength, string truncationSuffix = "…")
        {
            return value?.Length > maxLength
                ? value.Substring(0, maxLength) + truncationSuffix
                : value;
        }
    }
}
