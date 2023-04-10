using Lab02_WebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02_WebApplication3.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        Song s = new Song();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListSong()
        {
            var songs = s.getSong();
            return View(songs);
        }
        public ActionResult Detail(int id)
        {
            var song = s.getSong().Where(st => st.ID == id).FirstOrDefault();
            ViewBag.Song = song;
            return View(song);
        }
        public FileContentResult Download(int id)
        {
            var song = s.getSong().Where(st => st.ID == id).FirstOrDefault();
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath(song.url));
            string fileName = song.Name + ".mp3";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            return File(fileBytes, "audio/mp3", fileName);
        }
    }
}