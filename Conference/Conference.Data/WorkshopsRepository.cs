using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Conference.Data
{
    public interface IWorkshopsRepository
    {
        IEnumerable<Workshops> GetAllWorkshops();

        Workshops GetWorkshopById(int id);

        Workshops Update(Workshops workshopToUpdate);

        Workshops AddWorkshop(Workshops workshopToAdd);

        bool IsUniqueWorkshop(string workshopName);

        void Delete(Workshops workshopToDelete);

        void Save();
    }
    public class WorkshopsRepository : IWorkshopsRepository
    {
        private readonly ConferenceContext conferenceContext;

        public WorkshopsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public IEnumerable<Workshops> GetAllWorkshops()
        {
            return conferenceContext.Workshops.Include(x => x.Speaker).ToList();
        }

        public Workshops AddWorkshop(Workshops workshopToAdd)
        {
            var addedWorkshop = conferenceContext.Add(workshopToAdd);
            conferenceContext.SaveChanges();
            return addedWorkshop.Entity;
        }


        public Workshops GetWorkshopById(int id)
        {
            return conferenceContext.Workshops.Find(id);
        }


        public Workshops Update(Workshops workshopToUpdate)
        {
            var updatedWorkshop = conferenceContext.Update(workshopToUpdate);
            conferenceContext.SaveChanges();
            return updatedWorkshop.Entity;
        }

        public bool IsUniqueWorkshop(string workshopName)
        {
            int nr = conferenceContext.Workshops.Count(x => x.Name == workshopName);
            if (nr == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(Workshops workshopToDelete)
        {
            workshopToDelete = conferenceContext.Workshops.Find(workshopToDelete.Id);
            conferenceContext.Workshops.Remove(workshopToDelete);
            conferenceContext.SaveChanges();

        }
        public void Save()
        {
            conferenceContext.SaveChanges();
        }
    }
}
