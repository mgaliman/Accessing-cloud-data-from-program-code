using System.Web.Mvc;

namespace Movies.Controllers
{
    public class FilesController : Controller
    {
        ~FilesController()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
        private readonly ModelContainer db = new ModelContainer();
        // GET: Files
        public ActionResult Index(int id)
        {
            var uploadedFile = db.UploadedFiles.Find(id);
            return File(uploadedFile.Content, uploadedFile.ContentType);
        }
        public ActionResult Delete(int id)
        {
            db.UploadedFiles.Remove(db.UploadedFiles.Find(id));
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.AbsolutePath);
        }
    }
}