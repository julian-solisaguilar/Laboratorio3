using System;

namespace Laboratorio3.Models
{
  public class SongsModel
  {

    public string Name { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string Album { get; set; }
    public DateTime ReleasedDate { get; set; }
    public TimeSpan Duration { get; set; }

  }
}