using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Animal
    {
        private string nameOfAnimal;
        public string NameOfAnimal { get { return nameOfAnimal; } set { nameOfAnimal = value; } }

        private string habitat_area;
        public string HabitatArea { get { return habitat_area; } set { habitat_area = value; } }

        private string sound;
        public string Sound { get { return sound; } set { sound = value; } }

        private Int32 weight;
        public Int32 Weight { get { return weight; } set { weight = value; } }

        private Int32 height;
        public Int32 Height { get { return height; } set { height = value; } }

        public Int32 age;
        public Int32 Age { get { return age; } set { age = value; } }
        public Animal(string name, string habitat, string sound, Int32 weight, Int32 height)
        {
            this.nameOfAnimal = name;
            this.habitat_area = habitat;
            this.sound = sound;
            this.weight = weight;
            this.height = height;
        }


        public Int32 getage()
        {
            return age;
        }

        public void changeWeight(Int32 pounds)
        {
            this.Weight = pounds;
        }

        public string vocalize()
        {
            return sound;
        }

        public string getInformation()
        {
            string set = nameOfAnimal + " " + habitat_area + " " + sound + " " + height.ToString() + " " + weight.ToString() + " " + age.ToString();
            return set;
        }
    }
}
