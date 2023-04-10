using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02_WebApplication3.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string url { get; set; }
        public string singer { get; set; }
        public Song()
        {

        }
        public Song(int ID, string Name, string url, string singer)
        {
            this.ID = ID;
            this.Name = Name;
            this.url = url;
            this.singer = singer;
        }
        public List<Song> getSong()
        {
            List<Song> songs = new List<Song>();
            songs.Add(new Song(1, "Chưa quên ngươi yêu cũ", "/Content/song/chuaquennguoiyeucu-hanhi.mp3", "Hà Nhi"));
            songs.Add(new Song(2, "Cô đơn trên sofa", "/Content/song/codontrensofa-trungquan.mp3", "Trung Quân"));
            songs.Add(new Song(3, "Khuất lối", "/Content/song/khuatloi-hkray.mp3", "H-Kray"));
            songs.Add(new Song(4, "Luôn yêu đời", "/Content/song/luonyeudoi-den.mp3", "Đen Vâu"));
            songs.Add(new Song(5, "Nàng thơ", "/Content/song/nangtho-hoangdung.mp3", "Hoàng Dũng"));
            songs.Add(new Song(6, "Người rất tốt không gặp sẽ tốt hơn", "/Content/song/nguoirattotkhonggapsetothon-hienho.mp3", "Hà Nhi"));
            songs.Add(new Song(7, "Nơi tình yêu bắt đầu", "/Content/song/noitinhyeubatdau-buianhtuan.mp3", "Bùi Anh Tuấn"));
            songs.Add(new Song(8, "Quả phụ tướng", "/Content/song/quaphutuong-dunghoangpham.mp3", "Dunghoangpham"));

            return songs;
        }
    }
}