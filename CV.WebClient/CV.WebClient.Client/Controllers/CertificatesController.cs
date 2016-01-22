namespace CV.WebClient.Client.Controllers
{
    using System.Web.Mvc;

    public class CertificatesController : Controller
    {
        [Route("Certificates")]
        public ActionResult GetAll()
        {
            return View();
        }
    }
}