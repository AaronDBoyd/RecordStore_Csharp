using Microsoft.EntityFrameworkCore;

namespace RecordStore.Models
{
  public class RecordStoreContext : DbContext
  {
    public DbSet<Artist> Artists { get; set; }
    public DbSet<AlbumArtist> AlbumArtist { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }

    public RecordStoreContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}