using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Conference.Data;

namespace Conference.Service
{
    public interface IWorkshopsService
    {
        IEnumerable<Workshops> GetAllWorkshops();

        Workshops GetWorkshopById(int id);

        Workshops AddWorkshop(Workshops workshopToAdd);

        Workshops UpdateWorkshop(Workshops workshopToUpdate);

        void Delete(Workshops workshopToDelete);

        void Save();
    }

    public class WorkshopsService : IWorkshopsService
    {
        private readonly IWorkshopsRepository workshopRepository;

        public WorkshopsService(IWorkshopsRepository workshopRepository)
        {
            this.workshopRepository = workshopRepository;
        }

        private bool IsUniqueWorkshop(string workshopName)
        {
            if (workshopRepository.IsUniqueWorkshop(workshopName) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Workshops AddWorkshop(Workshops workshopToAdd)
        {
            if (IsUniqueWorkshop(workshopToAdd.Name))
            {
                return workshopRepository.AddWorkshop(workshopToAdd);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Workshops> GetAllWorkshops()
        {
            return workshopRepository.GetAllWorkshops();
        }

        public Workshops GetWorkshopById(int id)
        {
            return workshopRepository.GetWorkshopById(id);
        }

        public Workshops UpdateWorkshop(Workshops workshopToUpdate)
        {
            return workshopRepository.Update(workshopToUpdate);
        }
        
        public void Delete(Workshops workshopToDelete)
        {
            workshopRepository.Delete(workshopToDelete);

        }
        public void Save()
        {
            workshopRepository.Save();
        }
    }
}
