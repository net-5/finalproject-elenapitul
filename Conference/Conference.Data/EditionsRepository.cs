using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IEditionsRepository
    {
        IEnumerable<Editions> GetAllEditions();

        Editions GetEditionById(int id);

        Editions Update(Editions editionToUpdate);

        Editions AddEdition(Editions editionToBeAdded);

        bool IsUniqueEdition(string editionName);

        void Delete(Editions editionToDelete);

        void Save();
    }
    public class EditionsRepository : IEditionsRepository
    {
        private readonly ConferenceContext conferenceContext;

        public EditionsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public IEnumerable<Editions> GetAllEditions()
        {
            return conferenceContext.Editions.ToList();
        }

        public Editions AddEdition(Editions editionToAdd)
        {
            var addedEdition = conferenceContext.Add(editionToAdd);
            conferenceContext.SaveChanges();
            return addedEdition.Entity;
        }


        public Editions GetEditionById(int id)
        {
            return conferenceContext.Editions.Find(id);
        }


        public Editions Update(Editions editionToUpdate)
        {
            var updatedEdition = conferenceContext.Update(editionToUpdate);
            conferenceContext.SaveChanges();
            return updatedEdition.Entity;
        }

        public bool IsUniqueEdition(string editionName)
        {
            int nr = conferenceContext.Editions.Count(x => x.Name == editionName);
            if (nr == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(Editions editionToDelete)
        {
            editionToDelete = conferenceContext.Editions.Find(editionToDelete.Id);
            conferenceContext.Editions.Remove(editionToDelete);
            conferenceContext.SaveChanges();

        }
        public void Save()
        {
            conferenceContext.SaveChanges();
        }
    }
}
