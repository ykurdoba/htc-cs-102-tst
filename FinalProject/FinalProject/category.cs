using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class topic
    {
        public string name { get; set; }
        public string weight { get; set; }
        public string height { get; set; }
        public string age { get; set; }
        public string type { get; set; }
        public string rating { get; set; }

        public topic(string Name, string Weight, string Height, string Age, string Type, string Rating)
        {
            name = Name;
            weight = Weight;
            height = Height;
            age = Age;
            type = Type;
            rating = Rating;
        }
    }


