using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OpenAQDemo.Models;

namespace OpenAQDemo.ViewModels.Options
{
    public class CitiesViewModel
    {
        public List<OpenAQ_City.Result> Cities { get; set; }
    }
}
