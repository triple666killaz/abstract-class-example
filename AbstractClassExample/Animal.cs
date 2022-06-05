using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassExample
{
    abstract class Animal
    {

        private string name = "Just animal";

        public Animal(string name)
        {
            this.name = name;
        }
        public abstract void Move();

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }


    }
}
