using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataTransfer.Models;

namespace MVC_DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewBag.sunucutarihi = DateTime.Now;
            //int vize=ViewBag.vize = 40;
            //int final=ViewBag.final = 50;
            //double ortalama =ViewBag.ortalama= vize * 0.4 + final * 0.6;
            //ViewBag.devamsizlik = false;
            //ViewBag.ogrencismi = "Mustafa Koca";
            //ViewBag.odevnotlari= new int[] { 2,3,4,5};

            ogrenci yeniogrenci = new ogrenci()
            {
                ogrenciadi = "Mustafa Koca",
                adresi = "aydın",
                bolumu = "bilgisayar",
                sinifi = 3,
                sunucutarihi = DateTime.Now,
                vize=40,
                final=50,
                ortalama=46
            };

            return View(yeniogrenci);
        }
    }
}