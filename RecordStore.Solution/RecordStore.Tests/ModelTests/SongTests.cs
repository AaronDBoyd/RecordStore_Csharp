using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RecordStore.Models;

namespace RecordStore.Tests 
{
  [TestClass]
  public class SongTests : IDisposable
  
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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_SongList()
    {
      // Arrange
      List<Song> newList = new List<Song> { };

      // Act
      List<Song> result = Song.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsSongs_SongList()
    {
      //Arrange
      string title01 = "Walk the dog";
      string title02 = "Wash the dishes";
      Song newSong1 = new Song(title01);
      Song newSong2 = new Song(title02);
      List<Song> newList = new List<Song> { newSong1, newSong2 };

      //Act
      List<Song> result = Song.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_SongsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Walk the dog.";
      Song newSong = new Song(title);

      //Act
      int result = newSong.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectSong_Song()
    {
      //Arrange
      string title01 = "Walk the dog";
      string title02 = "Wash the dishes";
      Song newSong1 = new Song(title01);
      Song newSong2 = new Song(title02);

      //Act
      Song result = Song.Find(2);

      //Assert
      Assert.AreEqual(newSong2, result);
    }

  }
}