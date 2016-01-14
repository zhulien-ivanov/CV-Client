namespace CV.WebClient.Client.Controllers
{
    using System.Web.Mvc;

    public class LanguagesController : Controller
    {
        [Route("languages/{id:int}")]
        public ActionResult GetById(int id)
        {
            ViewBag.LanguageId = id;

            return View();
        }
    }
}