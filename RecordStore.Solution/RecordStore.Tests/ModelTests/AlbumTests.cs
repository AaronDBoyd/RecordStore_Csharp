using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordStore.Models;
using System.Collections.Generic;
using System;

namespace RecordStore.Tests
{
  [TestClass]
  public class AlbumTests /*: IDisposable*/
  {

    // public void Dispose()
    // {
    //   Album.ClearAll();
    // }

    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("test album");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }
  }
}