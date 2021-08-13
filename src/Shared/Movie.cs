using System;

namespace Blazor.Movies.Shared
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime Release { get; set; }
        public string PosterURL { get; set; }
        public string ShortTitle
        {
            get
            {
                if (string.IsNullOrEmpty(Title)) 
                    return null;
                if (Title.Length > 60) 
                    return Title.Substring(0, 60) + "...";
                else 
                    return Title;
            }
        }
    }
}
