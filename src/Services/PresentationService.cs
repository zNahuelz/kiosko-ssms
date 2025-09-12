using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kiosko_ssms.Services
{
    public class PresentationService
    {
        private readonly AppDbContext dbContext;

        public PresentationService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Presentation> GetAllPresentations(bool showDeleted)
        {
            var presentations = dbContext.Presentations.Where(p => showDeleted || !p.IsDeleted).OrderBy(p => p.Name).ToList();
            return presentations;
        }

        public List<Presentation> GetPresentationsById(int id, bool showDeleted)
        {
            var presentations = dbContext.Presentations
                .Where(p => p.Id == id && (showDeleted || !p.IsDeleted))
                .OrderBy(p => p.Name)
                .ToList();
            return presentations;
        }

        public List<Presentation> GetPresentationsByName(string name, bool showDeleted)
        {
            var presentations = dbContext.Presentations
                .Where(p => p.Name.ToUpper().Contains(name) && (showDeleted || !p.IsDeleted))
                .OrderBy(p => p.Name)
                .ToList();
            return presentations;
        }

        public List<Presentation> GetPresentationsByUnit(string unit, bool showDeleted)
        {
            var presentations = dbContext.Presentations
                .Where(p => p.Unit.ToUpper().Contains(unit) && (showDeleted || !p.IsDeleted))
                .OrderBy(p => p.Name)
                .ToList();
            return presentations;
        }

        public Presentation CreatePresentation(Presentation presentation)
        {
            presentation.Name = presentation?.Name?.Trim().ToUpper();
            presentation.Unit = presentation?.Unit?.Trim().ToUpper();
            presentation.IsDeleted = false;
            presentation.CreatedAt = DateTime.UtcNow;
            presentation.UpdatedAt = DateTime.UtcNow;
            bool exists = dbContext.Presentations.Any(p => p.Name == presentation.Name && p.Unit == presentation.Unit && p.Quantity == presentation.Quantity);
            if (exists)
            {
                throw new System.InvalidOperationException("Ya existe una presentación registrada con el nombre, cantidad y unidad ingresados.");
            }
            dbContext.Presentations.Add(presentation);
            dbContext.SaveChanges();
            return presentation;
        }

        public Presentation UpdatePresentation(Presentation presentation)
        {
            var existing = dbContext.Presentations.Find(presentation.Id);
            if (existing == null)
            {
                throw new InvalidOperationException("No se encontró la presentación especificada.");
            }
            existing.Name = presentation?.Name?.Trim().ToUpper();
            existing.Quantity = presentation.Quantity;
            existing.Unit = presentation?.Unit?.Trim().ToUpper();
            existing.IsDeleted = presentation.IsDeleted;
            existing.UpdatedAt = DateTime.UtcNow;
            bool exists = dbContext.Presentations.Any(p => p.Id != presentation.Id && p.Name == existing.Name && p.Unit == existing.Unit && p.Quantity == existing.Quantity);
            if (exists)
            {
                throw new System.InvalidOperationException("Ya existe una presentación registrada con el nombre, cantidad y unidad ingresados.");
            }
            dbContext.SaveChanges();
            return existing;
        }
    }
}
