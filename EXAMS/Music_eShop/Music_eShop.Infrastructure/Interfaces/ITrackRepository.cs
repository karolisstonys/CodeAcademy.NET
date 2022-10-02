using Music_eShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Infrastructure.Interfaces
{
    public interface ITrackRepository
    {
        public List<Track> GetTracksSortedByNameAsc();
        public List<Track> GetTracksSortedByNameDesc();
        public List<Track> GetTracksSortedByComposer();
        public List<Track> GetTracksSortedByGenre();
        public List<Track> GetTracksSortedByComposerAndAlbum();
        public List<Track> FindTracksById(string searchText);
        public List<Track> FindTracksByName(string searchText);
        public List<Track> FindTracksByComposer(string searchText);
        public List<Track> FindTracksByGenre(string searchText);
        public List<Track> FindTracksByComposerAndAlbum(string searchText);
        public List<Track> FindTracksByMilliseconds(string from, string to);
        public List<Track> FindTracksByAlbumAndArtist(string searchText);
        public void Print(List<Track> tracks);
    }
}
