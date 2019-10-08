using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Conference.Data;

namespace Conference.Service
{
    public interface ISpeakersService
    {
        IEnumerable<Speakers> GetAllSpeakers();

        Speakers GetSpeakerById(int id);

        Speakers AddSpeaker(Speakers speakerToAdd);

        Speakers UpdateSpeaker(Speakers speakerToUpdate);

        void Delete(Speakers speakerToDelete);

        void Save();
    }
    public class SpeakersService : ISpeakersService
    {
        private readonly ISpeakersRepository speakersRepository;

        public SpeakersService(ISpeakersRepository speakersRepository)
        {
            this.speakersRepository = speakersRepository;
        }

        public IEnumerable<Speakers> GetAllSpeakers()
        {
            return speakersRepository.GetAllSpeakers();
        }

        public Speakers GetSpeakerById(int id)
        {
            return speakersRepository.GetSpeakersById(id);
        }

        public Speakers AddSpeaker(Speakers speakerToAdd)
        {
            if (IsUniqueSpeaker(speakerToAdd.FullName))
            {
                return speakersRepository.AddSpeaker(speakerToAdd);
            }
            else
            {
                return null;
            }
        }
           
        public Speakers UpdateSpeaker(Speakers speakerToUpdate)
        {
            return speakersRepository.Update(speakerToUpdate);
        }

        private bool IsUniqueSpeaker(string speakerName)
        {
            if (speakersRepository.IsUniqueSpeaker(speakerName) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(Speakers speakerToDelete)
        {
            speakersRepository.Delete(speakerToDelete);
        }

        public void Save()
        {
            speakersRepository.Save();
        }
    }
}
