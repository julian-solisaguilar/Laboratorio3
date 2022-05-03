using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Laboratorio3.Controllers
{
  public class SongsController : Controller
  {
    public IActionResult Index()
    {
      var songs = GetListOfSongs();
      ViewBag.MainTitle = "List of my favorite songs";
      return View(songs);
    }

    private List<SongsModel> GetListOfSongs()
    {
      List<SongsModel> songs = new List<SongsModel>();
      songs.Add(new SongsModel { Name = "Close To You", Author = "Dayglow", Genre = "Alternative/Indie",
        Album = "Harmony House", ReleasedDate = new DateTime (2021, 01, 12), Duration = new TimeSpan(-00,3,15) });
      songs.Add(new SongsModel { Name = "Tiroteo - Remix", Author = "Marc Seguí, Rauw Alejandro, Pol Granch", 
        Genre = "Alternative/Indie", Album = "Tiroteo (Remix)", ReleasedDate = new DateTime (2021, 04, 01), 
          Duration = new TimeSpan(-00,5,21) });
      songs.Add(new SongsModel { Name = "Nightmare", Author = "Avenged Sevenfold", Genre = "Heavy Metal",
        Album = "Nightmare", ReleasedDate = new DateTime (2010, 07, 23), Duration = new TimeSpan(-00,6,14) });

      return songs;
    }
  }
}