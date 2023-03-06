using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {

        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public Person(string Name, DateTime BirthDate, double Height, bool IsMarried, int NoOfChildren) 
            {
            name = Name;
            birthDate = BirthDate;
            height = Height;
            isMarried = IsMarried;
            noOfChildren = NoOfChildren;
            }      
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public double Height
        {
            get { return height; }
            set { this.height = value; }
        }
        public bool IsMarried
        {
            get { return isMarried; }
            set { this.isMarried = value; }
        }
        public int NoOfChildren
        {
            get { return this.noOfChildren; }
            set { this.noOfChildren = value; }
        }


        public string MakeTitle()
        {
            //return $"{this.Name};{this.BirthDate};{this.Height};{this.IsMarried};{this.NoOfChildren}";
            return $"{Name};{BirthDate.ToString("dd-MM-yyyy HH':'mm':'ss")};{Height};{IsMarried};{NoOfChildren}";
        }


    }
}
