using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ToaDo
    {
        private string Name;
        private float X, Y;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public float x
        {
            get { return X; }
            set { X = value; }
        }
        public float y
        {
            get { return Y; }
            set { Y = value; }
        }

        public ToaDo() { }
        public ToaDo(string name, float x, float y)
        {
            X = x;
            Y = y;
            Name = name;
        }

    }
}
