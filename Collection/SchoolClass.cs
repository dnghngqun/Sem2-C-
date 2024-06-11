using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection
{
    public class SchoolClass
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Class ID: {Id}, Name: {Name}";
        }
    }
}