/* Name: diego arriaga
 * Date: 9/7/21
 * Description: Dino Inheritance
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _352_PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Name:");
            name = Console.ReadLine();

            Stegosaurus s = new Stegosaurus("joe", 22, 7230, "huh", 6);

            s.printInfo();
            s.ageUp();
            s.makeNoise();

            Pterodactyl p = new Pterodactyl("bow", 15, 120, "ka", 20);

            p.printInfo();
            p.ageUp();
            p.makeNoise();

            Triceratops t = new Triceratops("tre", 4, 82, "qu", 2);

            t.printInfo();
            t.ageUp();
            t.makeNoise();

            name = Console.ReadLine();
        }
    }
    abstract class Dino
    {
        private string Name = "Default";
        private int Age = 0;
        private string Noise = "Default";
        private int Weight = 0;

        public virtual void printInfo()
        {
            //Console.Write("Name: " + Name + " Age: " + Age + " Weight: " + Weight + " Noise: " + Noise);
        }

        public virtual void makeNoise()
        {
            //Console.WriteLine(Noise);
        }

        public virtual void ageUp()
        {
            Age++;
            //Console.WriteLine(Name + " is now " + Age);
        }
        
    }

    class Stegosaurus : Dino
    {
        private string Name;
        private int Age;
        private int Weight;
        private string Noise;
        int numPlates;
        public Stegosaurus(string name, int age, int weight, string noise, int numplates)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Noise = noise;
            this.numPlates = numplates;
        }
        public override void printInfo()
        {
            Console.Write("Name: " + Name + " Age: " + Age + " Weight: " + Weight + " Noise: " + Noise);
            Console.WriteLine(" Number of plates: " + numPlates);
        }
        
        public override void makeNoise()
        {
            Console.WriteLine(Noise);
        }
        public override void ageUp()
        {
            //ageUp();
            Age++;
            Console.WriteLine(Name + " is now " + Age);
        }

    }
    class Pterodactyl : Dino
    {
        private string Name;
        private int Age;
        private int Weight;
        private string Noise;
        private int wingSpan;
        public Pterodactyl(string name, int age, int weight, string noise, int wingspan)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Noise = noise;
            this.wingSpan = wingspan;
        }
        public override void printInfo()
        {
            Console.Write("Name: " + Name + " Age: " + Age + " Weight: " + Weight + " Noise: " + Noise);
            Console.WriteLine(" Wingspan: " + wingSpan);
        }
        public override void makeNoise()
        {
            Console.WriteLine(Noise);
        }
        public override void ageUp()
        {
            Age++;
            Console.WriteLine(Name + " is now " + Age);
        }
    }
    class Triceratops : Dino
    {
        private string Name;
        private int Age;
        private int Weight;
        private string Noise;
        private int Horns;
        public Triceratops(string name, int age, int weight, string noise, int horns)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Noise = noise;
            this.Horns = horns;
        }
        public override void printInfo()
        {
            Console.Write("Name: " + Name + " Age: " + Age + " Weight: " + Weight + " Noise: " + Noise);
            Console.WriteLine(" Number of horns: " + Horns);
        }
        public override void makeNoise()
        {
            Console.WriteLine(Noise);
        }
        public override void ageUp()
        {
            Age++;
            Console.WriteLine(Name + " is now " + Age);
        }
    }
}
 

