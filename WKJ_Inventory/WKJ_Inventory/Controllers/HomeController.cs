using System.Linq;
using System.Web.Mvc;
using WKJ_Inventory.Models;

namespace WKJ_Inventory.Controllers
{
    public class HomeController : Controller
    {
        private ItemDbContext _itemDbContext = new ItemDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult View()
        {
            var list = _itemDbContext.Items.ToList();
            return View(list);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Item item)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}