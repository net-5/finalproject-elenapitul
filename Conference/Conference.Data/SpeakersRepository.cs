﻿using System;
using System.Collections.Generic;
using System.Text;
using Conference.Domain.Entities;
using System.Linq;

namespace Conference.Data
{
    public interface ISpeakersRepository
    {
        IEnumerable<Speakers> GetAllSpeakers();

        Speakers GetSpeakersById(int id);

        Speakers Update(Speakers speakerToUpdate);

        Speakers AddSpeaker(Speakers speakerToAdd);

        bool IsUniqueSpeaker(string speakerName);

        void Delete(Speakers speakerToDelete);

        void Save();
    }


    public class SpeakersRepository : ISpeakersRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SpeakersRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public IEnumerable<Speakers> GetAllSpeakers()
        {
            return conferenceContext.Speakers.ToList();
        }

        public Speakers AddSpeaker(Speakers speakerToAdd)
        {
            var addedSpeaker = conferenceContext.Add(speakerToAdd);
            conferenceContext.SaveChanges();
            return addedSpeaker.Entity;
        }

        public Speakers GetSpeakersById(int id)
        {
            return conferenceContext.Speakers.Find(id);
        }

        public Speakers Update(Speakers speakerToUpdate)
        {
            var updatedSpeaker = conferenceContext.Update(speakerToUpdate);
            conferenceContext.SaveChanges();
            return updatedSpeaker.Entity;
        }

        public bool IsUniqueSpeaker(string speakerName)
        {
            int nr = conferenceContext.Speakers.Count(x => x.FullName == speakerName);
            if (nr == 0)
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
            speakerToDelete = conferenceContext.Speakers.Find(speakerToDelete.Id);
            conferenceContext.Speakers.Remove(speakerToDelete);
            conferenceContext.SaveChanges();

        }
        public void Save()
        {
            conferenceContext.SaveChanges();
        }


    }
}
