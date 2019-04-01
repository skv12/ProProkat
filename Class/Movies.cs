using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProProkat
{
    /***********************************************************************
 * Module:  movies.cs
 * Author:  Student
 * Purpose: Definition of the Class movies
 ***********************************************************************/

    public class movies
    {
        public List<Genres> Genres { get; set; }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddGenres(Genres newGenres)
        {
            if (newGenres == null)
                return;
            if (this.Genres == null)
                this.Genres = new System.Collections.ArrayList();
            if (!this.Genres.Contains(newGenres))
                this.Genres.Add(newGenres);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveGenres(Genres oldGenres)
        {
            if (oldGenres == null)
                return;
            if (this.Genres != null)
                if (this.Genres.Contains(oldGenres))
                    this.Genres.Remove(oldGenres);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllGenres()
        {
            if (Genres != null)
                Genres.Clear();
        }
        public System.Collections.ArrayList country;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetCountry()
        {
            if (country == null)
                country = new System.Collections.ArrayList();
            return country;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetCountry(System.Collections.ArrayList newCountry)
        {
            RemoveAllCountry();
            foreach (country ocountry in newCountry)
                AddCountry(ocountry);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddCountry(country newCountry)
        {
            if (newCountry == null)
                return;
            if (this.country == null)
                this.country = new System.Collections.ArrayList();
            if (!this.country.Contains(newCountry))
                this.country.Add(newCountry);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveCountry(country oldCountry)
        {
            if (oldCountry == null)
                return;
            if (this.country != null)
                if (this.country.Contains(oldCountry))
                    this.country.Remove(oldCountry);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllCountry()
        {
            if (country != null)
                country.Clear();
        }
        public System.Collections.ArrayList director;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetDirector()
        {
            if (director == null)
                director = new System.Collections.ArrayList();
            return director;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetDirector(System.Collections.ArrayList newDirector)
        {
            RemoveAllDirector();
            foreach (director odirector in newDirector)
                AddDirector(odirector);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddDirector(director newDirector)
        {
            if (newDirector == null)
                return;
            if (this.director == null)
                this.director = new System.Collections.ArrayList();
            if (!this.director.Contains(newDirector))
                this.director.Add(newDirector);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveDirector(director oldDirector)
        {
            if (oldDirector == null)
                return;
            if (this.director != null)
                if (this.director.Contains(oldDirector))
                    this.director.Remove(oldDirector);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllDirector()
        {
            if (director != null)
                director.Clear();
        }
        public System.Collections.ArrayList scenarist;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetScenarist()
        {
            if (scenarist == null)
                scenarist = new System.Collections.ArrayList();
            return scenarist;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetScenarist(System.Collections.ArrayList newScenarist)
        {
            RemoveAllScenarist();
            foreach (scenarist oscenarist in newScenarist)
                AddScenarist(oscenarist);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddScenarist(scenarist newScenarist)
        {
            if (newScenarist == null)
                return;
            if (this.scenarist == null)
                this.scenarist = new System.Collections.ArrayList();
            if (!this.scenarist.Contains(newScenarist))
                this.scenarist.Add(newScenarist);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveScenarist(scenarist oldScenarist)
        {
            if (oldScenarist == null)
                return;
            if (this.scenarist != null)
                if (this.scenarist.Contains(oldScenarist))
                    this.scenarist.Remove(oldScenarist);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllScenarist()
        {
            if (scenarist != null)
                scenarist.Clear();
        }
        public System.Collections.ArrayList actors;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetActors()
        {
            if (actors == null)
                actors = new System.Collections.ArrayList();
            return actors;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetActors(System.Collections.ArrayList newActors)
        {
            RemoveAllActors();
            foreach (actors oactors in newActors)
                AddActors(oactors);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddActors(actors newActors)
        {
            if (newActors == null)
                return;
            if (this.actors == null)
                this.actors = new System.Collections.ArrayList();
            if (!this.actors.Contains(newActors))
                this.actors.Add(newActors);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveActors(actors oldActors)
        {
            if (oldActors == null)
                return;
            if (this.actors != null)
                if (this.actors.Contains(oldActors))
                    this.actors.Remove(oldActors);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllActors()
        {
            if (actors != null)
                actors.Clear();
        }

        private DateTime year{get; set;}
        private int agerating{get; set;}
        private String name{get; set;}
        private String synopsis{get; set;}

    }
}
