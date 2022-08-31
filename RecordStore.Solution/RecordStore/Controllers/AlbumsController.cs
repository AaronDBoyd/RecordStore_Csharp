// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using RecordStore.Models;
// using Microsoft.EntityFrameworkCore;

// namespace RecordStore.Controllers
// {
//   public class AlbumsController : Controller
//   {
//     private readonly RecordStoreContext _db;

//     public AlbumsController(RecordStoreContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Album> model = _db.Albums.ToList();
//       return View(model);
//     }

//     public ActionResult Create()
//     {
//         return View();
//     }

//     [HttpPost]
//     public ActionResult Create(Album album)
//     {
//         _db.Albums.Add(album);
//         _db.SaveChanges();
//         return RedirectToAction("Index");
//     }

//     public ActionResult Details(int id)
//     {
//         Album thisAlbum = _db.Albums.FirstOrDefault(album => album.AlbumId == id);
//         return View(thisAlbum);
//     }

//     public ActionResult Edit(int id)
//     {
//         var thisAlbum = _db.Albums.FirstOrDefault(album => album.AlbumId == id);
//         return View(thisAlbum);
//     }

//     [HttpPost]
//     public ActionResult Edit(Album album)
//     {
//         _db.Entry(album).State = EntityState.Modified;
//         _db.SaveChanges();
//         return RedirectToAction("Index");
//     }
    
//     public ActionResult Delete(int id)
//     {
//         var thisAlbum = _db.Albums.FirstOrDefault(album => album.AlbumId == id);
//         return View(thisAlbum);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//         var thisAlbum = _db.Albums.FirstOrDefault(album => album.AlbumId == id);
//         _db.Albums.Remove(thisAlbum);
//         _db.SaveChanges();
//         return RedirectToAction("Index");
//     }
//   }
// }
