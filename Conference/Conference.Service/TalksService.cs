using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Conference.Data;

namespace Conference.Service
{
    public interface ITalksService
    {
        IEnumerable<Talks> GetAllTalks();

        Talks GetTalkById(int id);

        Talks AddTalk(Talks talkToAdd);

        Talks UpdateTalk(Talks talkToUpdate);

        void Delete(Talks talkToDelete);

        void Save();
    }
    public class TalksService : ITalksService
    {
        private readonly ITalksRepository talksRepository;

        public TalksService(ITalksRepository talksRepository)
        {
            this.talksRepository = talksRepository;
        }

        public IEnumerable<Talks> GetAllTalks()
        {
            return talksRepository.GetAllTalks();
        }

        public Talks GetTalkById(int id)
        {
            return talksRepository.GetTalkById(id);
        }

        private bool IsUniqueTalk(string talkName)
        {
            if (talksRepository.IsUniqueTalk(talkName) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Talks AddTalk(Talks talkToAdd)
        {
            if (IsUniqueTalk(talkToAdd.Name))
            {
                return talksRepository.AddTalk(talkToAdd);
            }
            else
            {
                return null;
            }
        }

        public Talks UpdateTalk(Talks talkToUpdate)
        {
            return talksRepository.Update(talkToUpdate);
        }

        public void Delete(Talks talkToDelete)
        {
            talksRepository.Delete(talkToDelete);
        }
                        
        public void Save()
        {
            talksRepository.Save();
        }

        
    }
}
