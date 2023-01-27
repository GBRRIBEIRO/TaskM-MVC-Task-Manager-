using Microsoft.AspNetCore.Mvc;
using TaskM.Data;
using TaskM.Data.Repository;
using TaskM.Models.WorkItems;

namespace TaskM.Controllers
{
    public class WorkItemController : Controller
    {
        private DatabaseContext _dbContext;
        private Repository<WorkItem> _repository; 

        public WorkItemController() {
            _dbContext = new DatabaseContext();
            _repository = new Repository<WorkItem>(_dbContext);
        }
        public ActionResult Index()
        {
            var workItems = _repository.GetAll();
            return View("Index",workItems.ToArray());
            
        }

        [HttpPost]
        public IActionResult Add()
        {

            return View("Index");
        }
    }
}
