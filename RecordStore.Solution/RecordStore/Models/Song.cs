using System.Collections.Generic;

namespace RecordStore.Models
{
  public class Song
  {
    public int SongId { get; set; }
    public string Title { get; set; }
    public int AlbumId { get; set; }
    public virtual Album Album { get; set; }
  }
}