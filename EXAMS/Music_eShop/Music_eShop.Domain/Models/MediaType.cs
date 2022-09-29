using System;
using System.Collections.Generic;
using Music_eShop.Infrastructure;
using Music_eShop.Domain.Models;

namespace Music_eShop.Domain.Models
{
    public partial class MediaType
    {
        public MediaType()
        {
            Tracks = new HashSet<Track>();
        }

        public long MediaTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
