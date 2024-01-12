using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square
    {
        //attributes
        public string Name { get; set; }
        public List Items { get; set; }
        public string Description { get; set; }
        public bool Enemy { get; set; }
        
        //constructor
        public Square(string Name, string Description, bool Enemy, List Items)
        {
            string name = Name;
            string description = Description;
            bool enemy = Enemy;
            List items = Items;
        }
        //methods
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
