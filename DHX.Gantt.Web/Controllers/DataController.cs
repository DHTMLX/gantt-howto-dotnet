using System.Web.Http;
using DHX.Gantt.Web.Models;

namespace DHX.Gantt.Web.Controllers
{
    [GanttAPIExceptionFilter]
    public class DataController : ApiController
    {
        // GET api/
        [System.Web.Http.HttpGet]
        public GanttDto Get()
        {
            return new GanttDto
            {
                data = new TaskController().Get(),
                links = new LinkController().Get()
            };
        }
    }
}