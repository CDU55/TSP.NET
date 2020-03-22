using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEFCore
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public List<AlbumArtist> Relations { get; set; }

        public Album()
        {
            this.Relations = new List<AlbumArtist>();
        }
    }
}
