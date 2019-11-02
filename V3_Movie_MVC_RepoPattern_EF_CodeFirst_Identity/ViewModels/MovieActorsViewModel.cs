using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Models;

namespace V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.ViewModels
{
    public class MovieActorsViewModel
    {
        public IEnumerable<Actor> Actors { get; set; }
        public List<SelectListItem> Movies { get; set; }

    }
}
