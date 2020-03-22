using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEFCore
{
    //Clasa generata pentru implementarea relatiei many to many dintre Album si Artist,in EF Core este necesar un bridge table explicit
    //atunci cand implementam o astfel de relatie
    public class AlbumArtist
    {
        public int AlbumId { get; set; }
        public Album CorrespondentAlbum { get; set; }
        public int ArtistId { get; set; }
        public Artist CorrespondentArtist { get; set; }
    }
}
