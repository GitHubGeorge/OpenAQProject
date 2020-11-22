using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace OpenAQDemo.ViewModels.Options
{
    public class OptionsViewModel
    {        
        public List<KeyValuePair<int, string>> Options { get; set; }
    }
}
