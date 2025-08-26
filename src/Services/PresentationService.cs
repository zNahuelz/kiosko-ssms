using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosko_ssms.Services
{
    public class PresentationService
    {
        private readonly AppDbContext dbContext;

        public PresentationService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Presentation> getAllPresentations(bool showDeleted)
        {
            var presentations = dbContext.Presentations.Where(p => showDeleted ? p.IsDeleted : !p.IsDeleted).OrderBy(p => p.Name).ToList();
            return presentations;
        }
    }
}
