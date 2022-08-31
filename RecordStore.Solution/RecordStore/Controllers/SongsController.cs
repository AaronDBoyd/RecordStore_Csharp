// using Microsoft.AspNetCore.Mvc;
// using RecordStore.Models;
// using System.Collections.Generic; 
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace RecordStore.Controllers
// {
//   public class SongsController : Controller
//   {
//     private readonly RecordStoreContext _db;

//     public SongsController(RecordStoreContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Song> model = _db.Songs.Include(song => song.Album).ToList();
//       ViewBag.PageTitle = "View All Songs";
//       return View(model);
//     }

//     public ActionResult Create()
//     {
//       ViewBag.AlbumId = new SelectList(_db.Albums, "AlbumId", "Name");
//       return View();
//     }

//     [HttpPost]
//     public ActionResult Create(Song song)
//     {
//         _db.Songs.Add(song);
//         _db.SaveChanges();
//         return RedirectToAction("Index");
//     }

//     public ActionResult Details(int id)
//     {
//         Song thisSong = _db.Songs.FirstOrDefault(song => song.SongId == id);
//         return View(thisSong);
//     }
    
//     public ActionResult Edit(int id)
//     {
//         var thisSong = _db.Songs.FirstOrDefault(song => song.SongId == id);
//         ViewBag.AlbumId = new SelectList(_db.Albums, "AlbumId", "Name");
//         return View(thisSong);
//     }

//     [HttpPost]
//     public ActionResult Edit(Song song)
//     {
//         _db.Entry(song).State = EntityState.Modified;
//         _db.SaveChanges();
//         return RedirectToAction("Index");
//     }

//     public ActionResult Delete(int id)
//     {
//         var thisSong = _db.Songs.FirstOrDefault(song => song.SongId == id);
//         return View(thisSong);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//         var thisSong = _db.Songs.FirstOrDefault(song => song.SongId == id);
//         _db.Songs.Remove(thisSong);
//         _db.SaveChanges();
//         return RedirectToAction("Index");
//     }
//   }
// }