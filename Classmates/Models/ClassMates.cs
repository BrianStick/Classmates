using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classmates.Models
{
    public class ClassMate
    {
        public ClassMate(string name, string hair, double height)
        {
            Name = name;
            HairColor = hair;
            Height = Height;
        }

        public string Name { get; set; }
        public string HairColor { get; set; }
        public int Height { get; set; }
    }
}