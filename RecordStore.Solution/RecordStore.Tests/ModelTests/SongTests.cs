using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RecordStore.Models;

namespace RecordStore.Tests 
{
  [TestClass]
  public class SongTests /*: IDisposable*/
  
  {

    public void Dispose() 
    {
      Song.ClearAll();
    }

    [TestMethod]
    public void SongConstructor_CreatesInstanceOfSong_Song()
    {
      Song newSong = new Song("test");
      Assert.AreEqual(typeof(Song), newSong.GetType());
    }

  }
}