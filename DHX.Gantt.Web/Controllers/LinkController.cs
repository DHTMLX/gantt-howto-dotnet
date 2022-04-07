using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using DHX.Gantt.Web.Models;

namespace DHX.Gantt.Web.Controllers
{
    [GanttAPIExceptionFilter]
    public class LinkController : ApiController
    {
        private GanttContext db = new GanttContext();

        // GET api/Link
        [System.Web.Http.HttpGet]
        public IEnumerable<LinkDto> Get()
        {
            return db
                .Links
                .ToList()
                .Select(l => (LinkDto)l);
        }

        // GET api/Link/5
        [System.Web.Http.HttpGet]
        public LinkDto Get(int id)
        {
            return (LinkDto)db
                .Links
                .Find(id);
        }

        // POST api/Link
        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateLink(LinkDto linkDto)
        {
            var newLink = (Link)linkDto;
            db.Links.Add(newLink);
            db.SaveChanges();

            return Ok(new
            {
                tid = newLink.Id,
                action = "inserted"
            });
        }

        // PUT api/Link/5
        [System.Web.Http.HttpPut]
        public IHttpActionResult EditLink(int id, LinkDto linkDto)
        {
            var clientLink = (Link)linkDto;
            clientLink.Id = id;

            db.Entry(clientLink).State = EntityState.Modified;
            db.SaveChanges();

            return Ok(new
            {
                action = "updated"
            });
        }

        // DELETE api/Link/5
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteLink(int id)
        {
            var link = db.Links.Find(id);
            if (link != null)
            {
                db.Links.Remove(link);
                db.SaveChanges();
            }
            return Ok(new
            {
                action = "deleted"
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}