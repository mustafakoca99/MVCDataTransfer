using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DataTransfer.Models
{
    public class ogrenci
    {
        public  string ogrenciadi{ get; set; }
        public string bolumu { get; set; }
        public int sinifi { get; set; }
        public string adresi { get; set; }
        public DateTime sunucutarihi { get; set; }
        public  int vize { get; set; }
        public int final { get; set; }
        public double ortalama { get; set; }
    }
}