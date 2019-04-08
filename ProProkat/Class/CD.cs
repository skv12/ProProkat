using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProProkat 
{
    /***********************************************************************
 * Module:  CD.cs
 * Author:  Student
 * Purpose: Definition of the Class CD
 ***********************************************************************/


    public class CD 
    {
        public System.Collections.ArrayList movies;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetMovies()
        {
            if (movies == null)
                movies = new System.Collections.ArrayList();
            return movies;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetMovies(System.Collections.ArrayList newMovies)
        {
            RemoveAllMovies();
            foreach (movies omovies in newMovies)
                AddMovies(omovies);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddMovies(movies newMovies)
        {
            if (newMovies == null)
                return;
            if (this.movies == null)
                this.movies = new System.Collections.ArrayList();
            if (!this.movies.Contains(newMovies))
                this.movies.Add(newMovies);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveMovies(movies oldMovies)
        {
            if (oldMovies == null)
                return;
            if (this.movies != null)
                if (this.movies.Contains(oldMovies))
                    this.movies.Remove(oldMovies);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllMovies()
        {
            if (movies != null)
                movies.Clear();
        }

        private int count { get; set; }
        private String condition { get; set; }
        private int price { get; set; }
        private String status { get; set; }

    }
}
