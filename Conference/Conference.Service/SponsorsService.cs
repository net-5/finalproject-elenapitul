using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{

    public interface ISponsorsService
    {
        IEnumerable<Sponsors> GetAllSponsors();

        Sponsors GetSponsorById(int id);

        Sponsors AddSponsor(Sponsors sponsorToAdd);

        Sponsors UpdateSponsor(Sponsors sponsorToUpdate);

        void Delete(Sponsors sponsorToDelete);

        void Save();

    }

    public class SponsorsService : ISponsorsService
    {
        private readonly ISponsorsRepository sponsorsRepository;

        public SponsorsService (ISponsorsRepository sponsorsRepository)
        {
            this.sponsorsRepository = sponsorsRepository;
        }

        public IEnumerable<Sponsors> GetAllSponsors()
        {
            return sponsorsRepository.GetAllSponsors();
        }

        public Sponsors GetSponsorById(int id)
        {
            return sponsorsRepository.GetSponsorById(id);
        }

        public Sponsors AddSponsor (Sponsors sponsorToAdd)
        {
            if(IsUniqueSponsor(sponsorToAdd.Name))
            {
                return sponsorsRepository.AddSponsor(sponsorToAdd);
            }
            else
            {
                return null;
            }
        }

        public Sponsors UpdateSponsor (Sponsors sponsorToUpdate)
        {
            return sponsorsRepository.Update(sponsorToUpdate);
        }

        private bool IsUniqueSponsor (string sponsorName)
        {
            if (sponsorsRepository.IsUniqueSponsor(sponsorName) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete (Sponsors sponsorToDelete)
        {
            sponsorsRepository.Delete(sponsorToDelete);
        }

        public void Save()
        {
            sponsorsRepository.Save();
        }
    }
}
