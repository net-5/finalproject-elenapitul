using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorTypesRepository
    {
        IEnumerable<SponsorTypes> GetAllSponsorTypes();

        SponsorTypes GetSponsorTypeById(int id);

        SponsorTypes Update(SponsorTypes sponsorTypeToUpdate);

        SponsorTypes AddSponsorType(SponsorTypes sponsorTypeToAdd);

        bool IsUniqueSponsorType(string sponsoTypeName);

        void Delete(SponsorTypes sponsorTypeToDelete);

        void Save();


    }

    public class SponsorTypesRepository : ISponsorTypesRepository
    {

        private readonly ConferenceContext conferenceContext;

        public SponsorTypesRepository (ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public IEnumerable<SponsorTypes> GetAllSponsorTypes()
        {
            return conferenceContext.SponsorTypes.ToList();
        }
        
        public SponsorTypes AddSponsorType (SponsorTypes sponsorTypeToAdd)
        {
            var addedSponsorType = conferenceContext.Add(sponsorTypeToAdd);
            conferenceContext.SaveChanges();
            return addedSponsorType.Entity;
        }

        public SponsorTypes GetSponsorTypeById(int id)
        {
            return conferenceContext.SponsorTypes.Find(id);
        }

        public SponsorTypes Update(SponsorTypes sponsorTypeToUpdate)
        {
            var updatedSponsorType = conferenceContext.Update(sponsorTypeToUpdate);
            conferenceContext.SaveChanges();
            return updatedSponsorType.Entity;
        }

        public bool IsUniqueSponsorType (string sponsorTypeName)
        {
            int nr = conferenceContext.SponsorTypes.Count(x => x.Name == sponsorTypeName);
            if(nr == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(SponsorTypes sponsorTypeToDelete)
        {
            sponsorTypeToDelete = conferenceContext.SponsorTypes.Find(sponsorTypeToDelete.Id);
            conferenceContext.SponsorTypes.Remove(sponsorTypeToDelete);
            conferenceContext.SaveChanges();
        }

        public void Save()
        {
            conferenceContext.SaveChanges();
        }



    }
}
