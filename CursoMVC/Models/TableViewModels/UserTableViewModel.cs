using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC.Models.TableViewModels
{
    public class UserTableViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int? Edad { get; set; }

    }
}