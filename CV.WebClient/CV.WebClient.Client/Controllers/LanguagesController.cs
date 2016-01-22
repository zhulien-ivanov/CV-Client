namespace CV.WebClient.Client.Controllers
{
    using System.Web.Mvc;

    public class LanguagesController : Controller
    {
        [Route("Languages/{id:int}")]
        public ActionResult GetById(int id)
        {
            ViewBag.LanguageId = id;

            return View();
        }
    }
}