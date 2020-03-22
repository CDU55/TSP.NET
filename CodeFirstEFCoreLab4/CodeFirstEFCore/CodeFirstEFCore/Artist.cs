using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEFCore
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<AlbumArtist> Relations { get; set; }

        public Artist()
        {
            this.Relations = new List<AlbumArtist>();
        }
    }
}
