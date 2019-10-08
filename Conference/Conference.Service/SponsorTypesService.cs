using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorTypesService
    {
        IEnumerable<SponsorTypes> GetAllSponsorTypes();
        
        SponsorTypes GetSponsorTypeById(int id);

        SponsorTypes UpdateSponsorType(SponsorTypes sponsorTypeToUpdate);

        SponsorTypes AddSponsorType(SponsorTypes sponsorTypeToAdd);

        void Delete(SponsorTypes sponsorTypeToDelete);

        void Save();

    }

    public class SponsorTypesService : ISponsorTypesService
    {
        private readonly ISponsorTypesRepository sponsorTypesRepository;

        public SponsorTypesService (ISponsorTypesRepository sponsorTypesRepository)
        {
            this.sponsorTypesRepository = sponsorTypesRepository;
        }
        
        public SponsorTypes GetSponsorTypeById(int id)
        {
            return sponsorTypesRepository.GetSponsorTypeById(id);
        }

        public IEnumerable<SponsorTypes> GetAllSponsorTypes()
        {
            return sponsorTypesRepository.GetAllSponsorTypes();
        }

        private bool IsUniqueSponsorType (string sponsorTypeName)
        {
            if(sponsorTypesRepository.IsUniqueSponsorType(sponsorTypeName) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SponsorTypes AddSponsorType(SponsorTypes sponsorTypeToAdd)
        {
            if(IsUniqueSponsorType(sponsorTypeToAdd.Name))
            {
                return sponsorTypesRepository.AddSponsorType(sponsorTypeToAdd);
            }
            else
            {
                return null;
            }
        }

        public SponsorTypes UpdateSponsorType(SponsorTypes sponsorTypeToUpdate)
        {
            return sponsorTypesRepository.Update(sponsorTypeToUpdate);
        }

        public void Delete(SponsorTypes sponsorTypeToDelete)
        {
            sponsorTypesRepository.Delete(sponsorTypeToDelete);
        }

        public void Save()
        {
            sponsorTypesRepository.Save();
        }
    }
}
