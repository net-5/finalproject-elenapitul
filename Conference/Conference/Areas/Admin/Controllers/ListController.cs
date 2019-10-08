using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            return View();
        }
       
    }
}