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

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Walk the dog.";
      Song newSong = new Song(title);

      //Act
      string result = newSong.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Walk the dog.";
      Song newSong = new Song(title);

      //Act
      string updatedTitle = "Do the dishes";
      newSong.Title = updatedTitle;
      string result = newSong.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

  }
}