using System;
using System.Collections.Generic;
using Music_eShop.Domain.Models;
using Music_eShop.Infrastructure;

namespace Music_eShop.Domain.Models
{
    public partial class Artist
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
        }

        public long ArtistId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
