using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Teacher ID: {Id}, name: {Name}";
        }
    }
}