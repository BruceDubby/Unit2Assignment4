using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Please enter Employer name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Employer location")]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {

        }

        public AddEmployerViewModel(string location, string name)
        {
            this.Name = name;
            this.Location = location;
        }
    }
}
