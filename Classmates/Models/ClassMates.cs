using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classmates.Models
{
    public class ClassMate
    {
        public ClassMate(int id,string name, string hair, double height)
        {
            Id = id;
            Name = name;
            HairColor = hair;
            Height = Height;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string HairColor { get; set; }
        public int Height { get; set; }
    }
}