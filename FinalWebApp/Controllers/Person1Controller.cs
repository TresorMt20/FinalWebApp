using DataSide;
using FinalWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWebApp.Controllers
{
    public class Person1Controller : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private IPersonInterf _assets;

        public Person1Controller(IPersonInterf asset)
        {
            _assets = asset;
        }

        public string Gen()
        {
           // _assets.Add(new Person("Alpha", 24, "Bel", "45454", "@mail.com", "bel d nation"));

            //IActionResult
            ////var assetmodel = _assets.GetAll();

            ////var listingResult = assetmodel.Select(result => new AssetListingModel
            ////{
            ////    id = result.id,
            ////    name = result.name,
            ////    age = result.age,
            ////    address = result.address,
            ////    phoneNume = result.phoneNume,
            ////    email = result.email,
            ////    school = result.school

            ////});

            ////var model = new AssetIndexModel()
            ////{
            ////    Assets = listingResult
            ////};

            // return View(model);

            return "lol wecol oooooo go";
        }
    }
}
