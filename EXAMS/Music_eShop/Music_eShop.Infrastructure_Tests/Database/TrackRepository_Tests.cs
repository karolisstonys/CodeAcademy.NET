using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_eShop.Domain.Models;
using Music_eShop.Infrastructure.Database;
using Music_eShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Infrastructure.Database_Tests
{
    [TestClass()]
    public class TrackRepository_Tests
    {
        private ChinookContext _context;
        private ITrackRepository _tracks;

        [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<ChinookContext>()
                .UseInMemoryDatabase(databaseName: "Chinook")
                .Options;
            _context = new ChinookContext(options);

            var artist = new Artist() { ArtistId = 11, Name = "Artistas AA" };
            _context.Artists.Add(artist);

            var album = new Album() { AlbumId = 101, Title = "Albumas BB", Artist = artist };
            _context.Albums.Add(album);

            var genre = new Genre() { GenreId = 21, Name = "New Genre" };

            _context.Tracks.Add(new Track() { TrackId = 1001, Name = "Daina ABC", Composer = "Composer KLM", MediaTypeId = 1, Milliseconds = 185054, Album = album, AlbumId = album.AlbumId, UnitPrice = new byte[] { 0, 99 }, Genre = genre });
            _context.SaveChanges();
        }

        [TestMethod()]
        public void GetTracksSortedByNameAsc_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);
            var expected = new List<Track>();
            expected.Add(_context.Tracks.FirstOrDefault());

            //Act
            var actual = _tracks.GetTracksSortedByNameAsc();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTracksSortedByNameDesc_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);
            var expected = new List<Track>();
            expected.Add(_context.Tracks.FirstOrDefault());

            //Act
            var actual = _tracks.GetTracksSortedByNameDesc();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTracksSortedByComposer_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);
            var expected = new List<Track>();
            expected.Add(_context.Tracks.FirstOrDefault());

            //Act
            var actual = _tracks.GetTracksSortedByComposer();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTracksSortedByGenre_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);
            var expected = new List<Track>();
            expected.Add(_context.Tracks.FirstOrDefault());

            //Act
            var actual = _tracks.GetTracksSortedByGenre();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTracksSortedByComposerAndAlbum_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);
            var expected = new List<Track>();
            expected.Add(_context.Tracks.FirstOrDefault());

            //Act
            var actual = _tracks.GetTracksSortedByComposerAndAlbum();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTracksById_Pass_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);
            var expected = new List<Track>();
            expected.Add(_context.Tracks.FirstOrDefault());

            //Act
            var actual = _tracks.FindTracksById("1001");

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTracksById_Fail_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);
            var expected = new List<Track>();
            expected.Add(_context.Tracks.FirstOrDefault());

            //Act
            var actual = _tracks.FindTracksById("1002");

            //Assert
            CollectionAssert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTracksByName_Pass_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);

            //Act
            var actual = _tracks.FindTracksByName("Daina");

            //Assert
            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod()]
        public void FindTracksByName_Fail_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);

            //Act
            var actual = _tracks.FindTracksByName("Song");

            //Assert
            Assert.IsFalse(actual.Count > 0);
        }

        [TestMethod()]
        public void FindTracksByComposer_Pass_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);

            //Act
            var actual = _tracks.FindTracksByComposer("KLM");

            //Assert
            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod()]
        public void FindTracksByComposer_Fail_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);

            //Act
            var actual = _tracks.FindTracksByComposer("Anything");

            //Assert
            Assert.IsFalse(actual.Count > 0);
        }

        [TestMethod()]
        public void FindTracksByGenre_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);

            //Act
            var actual = _tracks.FindTracksByGenre("New");

            //Assert
            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod()]
        public void FindTracksByComposerAndAlbum_Test()
        {
            //Arrange
            _tracks = new TrackRepository(_context);

            //Act
            var actual = _tracks.FindTracksByComposerAndAlbum("KLM");

            //Assert
            Assert.IsTrue(actual.Count > 0);
        }
    }
}