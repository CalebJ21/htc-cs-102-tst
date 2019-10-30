using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class skoop : Animal
    {
        // public string Name;
        //public int height;

        // public int Height { get; private set; }

        public void Quack()
        {
            MessageBox.Show("Quack");

        }
        //public void SayName()
        //{
        //MessageBox.Show("My Name is Name");
        //}

        public skoop(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }

        
     
    }
}
