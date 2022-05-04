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
      ViewBag.MainTitle = "My favorite song";
      return View(songs);
    }

    private List<SongsModel> GetListOfSongs()
    {
      List<SongsModel> songs = new List<SongsModel>();
      songs.Add(new SongsModel { Name = "Close To You", Author = "Dayglow", Genre = "Alternative/Indie",
        Album = "Harmony House", ReleasedDate = new DateTime (2021, 01, 12), Duration = new TimeSpan(-00,3,15) });

      return songs;
    }
  }
}