using System.Collections.Generic;

namespace RecordStore.Models
{
    public class Artist
    {
        public Artist()
        {
            this.JoinEntities = new HashSet<AlbumArtist>();
        }

        public int ArtistId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AlbumArtist> JoinEntities { get; set; }
    }
}