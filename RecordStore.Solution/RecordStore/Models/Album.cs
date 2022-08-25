using System.Collections.Generic;

namespace RecordStore.Models
{
    public class Album
    {
        public Album()
        {
            this.Songs = new HashSet<Song>();
        }

        public int AlbumId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}