using Microsoft.AspNetCore.Mvc;
using RecordStore.Models;
using System.Collections.Generic; // allows use of Lists

namespace RecordStore.Controllers
{
  public class SongsController : Controller
  {

    [HttpGet("/albums/{albumId}/songs/new")]
    public ActionResult New(int albumId)
    {
      Album album = Album.Find(albumId);
      return View(album);
    }  

    [HttpPost("/songs/delete")]
    public ActionResult DeleteAll()
    {
      Song.ClearAll();
      return View();
    }

    [HttpGet("/albums/{albumId}/songs/{songId}")]
    public ActionResult Show(int albumId, int songId)
    {
      Song song = Song.Find(songId);
      Album album = Album.Find(albumId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("song", song);
      model.Add("album", album);
      return View(model);
    }
  }
}