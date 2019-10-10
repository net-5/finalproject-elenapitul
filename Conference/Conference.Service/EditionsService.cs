using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface IEditionsService
    {
        IEnumerable<Editions> GetAllEditions();

        Editions GetEditionById(int id);

        Editions AddEdition(Editions editionToAdd);

        Editions UpdateEdition(Editions editionToUpdate);        

        void Delete(Editions editionToDelete);

        void Save();
    }
    public class EditionsService : IEditionsService
    {
        private readonly IEditionsRepository editionRepository;

        public EditionsService(IEditionsRepository editionRepository)
        {
            this.editionRepository = editionRepository;
        }

        public Editions AddEdition(Editions editionToAdd)
        {
            if (IsUniqueEdition(editionToAdd.Name))
            {
                return editionRepository.AddEdition(editionToAdd);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Editions> GetAllEditions()
        {
            return editionRepository.GetAllEditions();
        }

        public Editions GetEditionById(int id)
        {
            return editionRepository.GetEditionById(id);
        }

        public Editions UpdateEdition(Editions editionToUpdate)
        {
            return editionRepository.Update(editionToUpdate);
        }

        private bool IsUniqueEdition(string editionName)
        {
            if (editionRepository.IsUniqueEdition(editionName) == true)
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
            editionRepository.Delete(editionToDelete);
           
        }

        public void Save()
        {
            editionRepository.Save();
        }
    }
}
