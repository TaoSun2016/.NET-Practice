using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        // GET: Browse
       /* public string Browse()
        {
            return "Hello from Store.Browse()";
        }
        */

        // GET: Browse
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store/browse Genre =" + genre);
            return message;
        }

        // GET: Details
        public string Details(int id)
        {
            string message = "Store:Details ID=" + id;
            return message;
        }
    }
}