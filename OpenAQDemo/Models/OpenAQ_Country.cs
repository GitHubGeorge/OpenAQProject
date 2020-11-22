using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenAQDemo.Models
{
    public class OpenAQ_Country
    {
        public class Meta
        {
            public string name { get; set; }
            public string license { get; set; }
            public string website { get; set; }
            public int page { get; set; }
            public int limit { get; set; }
            public int found { get; set; }
        }

        public class Result
        {
            public string code { get; set; }
            public int count { get; set; }
            public int locations { get; set; }
            public int cities { get; set; }
            public string name { get; set; }
        }

        public Meta meta { get; set; }
        public List<Result> results { get; set; }

    }
}
