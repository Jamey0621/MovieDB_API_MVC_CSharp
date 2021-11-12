using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovieApp.Models
{
    public class UserMovie 
    {
        public UserMovie()
        {
        }

        public int id { get; set; }
        public string backdrop_path { get; set; }
          
            public int movie_id { get; set; }

            public string poster_path { get; set; }
       
            public string title { get; set; }
      
        
    }
}
