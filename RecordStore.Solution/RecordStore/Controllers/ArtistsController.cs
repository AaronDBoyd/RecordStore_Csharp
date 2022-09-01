using Microsoft.AspNetCore.Mvc;
using RecordStore.Models;
using System.Collections.Generic; // allows use of Lists
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RecordStore.Controllers
{
  public class ArtistsController : Controller
  {
    private readonly RecordStoreContext _db;

    public ArtistsController(RecordStoreContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Artists.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.AlbumId = new SelectList(_db.Albums, "AlbumId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Artist artist, int AlbumId)
    {
        _db.Artists.Add(artist);
        _db.SaveChanges();
        if (AlbumId != 0)
        {
            _db.AlbumArtist.Add(new AlbumArtist() { AlbumId = AlbumId, ArtistId = artist.ArtistId });
            _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisArtist = _db.Artists
        .Include(artist => artist.JoinEntities)
        .ThenInclude(join => join.Album)
        .FirstOrDefault(artist => artist.ArtistId == id);
        return View(thisArtist);
    }

    public ActionResult Edit(int id)
    {
        var thisArtist = _db.Artists.FirstOrDefault(artist => artist.ArtistId == id);
        ViewBag.AlbumId = new SelectList(_db.Albums, "AlbumId", "Name");
        return View(thisArtist);
    }

    [HttpPost]
    public ActionResult Edit(Artist artist, int AlbumId)
    {
        if (AlbumId != 0)
        {
          _db.AlbumArtist.Add(new AlbumArtist() { AlbumId = AlbumId, ArtistId = artist.ArtistId });
        }
        _db.Entry(artist).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult AddAlbum(int id)
    {
        var thisArtist = _db.Artists.FirstOrDefault(artist => artist.ArtistId == id);
        ViewBag.AlbumId = new SelectList(_db.Albums, "AlbumId", "Name");
        return View(thisArtist);
    }

    [HttpPost]
    public ActionResult AddAlbum(Artist artist, int AlbumId)
    {
        if (AlbumId != 0)
        {
          _db.AlbumArtist.Add(new AlbumArtist() { AlbumId = AlbumId, ArtistId = artist.ArtistId });
          _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        var thisArtist = _db.Artists.FirstOrDefault(artist => artist.ArtistId == id);
        return View(thisArtist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisArtist = _db.Artists.FirstOrDefault(artist => artist.ArtistId == id);
        _db.Artists.Remove(thisArtist);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteAlbum(int joinId)
    {
        var joinEntry = _db.AlbumArtist.FirstOrDefault(entry => entry.AlbumArtistId == joinId);
        _db.AlbumArtist.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}