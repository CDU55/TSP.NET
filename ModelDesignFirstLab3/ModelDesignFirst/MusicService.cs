using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst
{
    public class MusicService
    {
        private readonly AlbumArtistContainer context;
        public MusicService(AlbumArtistContainer context)
        {
            this.context = context;
        }

        public void AddArtist(Artist a)
        {
            context.Artists.Add(a);
            context.SaveChanges();
        }

        public void AddAlbum(Album a)
        {
            context.Albums.Add(a);
            context.SaveChanges();
        }

        public Boolean BindAlbumAndArtist(int AlbumID, int ArtistID)
        {
            var artist = context.Artists.FirstOrDefault(a => a.ArtistId == ArtistID);
            var album = context.Albums.FirstOrDefault(a => a.AlbumId == AlbumID);
            if (artist != null && album != null)
            {
                artist.Albums.Add(album);
                album.Artists.Add(artist);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
