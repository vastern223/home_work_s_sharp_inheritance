using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_s_sharp_inheritance
{
    class Animal 
    {

        protected string name;
        protected string kind;

        public Animal()
        {
            name = "no name ";
            kind = "no_kind";

        }

        public Animal(string name, string kind)
        {
            this.name = name;
            this.kind = kind;

        }
        public virtual void Show_info()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("kind:" + kind);
        }

        public virtual void Say()
        {
            Console.Write("l say:");
        }

    }

    class Reptile : Animal
    {

        public int Temperature { get; set; }

        public Reptile() : base()
        {
            this.Temperature = 0;
        }

        public Reptile(string name, string kind, int Temperature) : base(name, kind)
        {
            this.Temperature = Temperature;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Temperature: " + Temperature);
        }

        public override void Say()
        {
            base.Say();

            Console.Write(" phssss,");
        }

    }
   
    class Bird : Animal
    {

        public float Wingspan { get; set; }

        public Bird() : base()
        {
            this.Wingspan = 0;
        }

        public Bird(string name, string kind, float Wingspan) : base(name, kind)
        {
            this.Wingspan = Wingspan;
        }
        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Wingspan: " + Wingspan);
        }

        public override void Say()
        {
            base.Say();
            Console.Write(" piiiii,");
        }
    }

    class Fish : Animal
    {

        public int Immersion_depth { get; set; }

        public Fish() : base()
        {
            this.Immersion_depth = 0;
        }

        public Fish(string name, string kind, int Immersion_depth) : base(name, kind)
        {
            this.Immersion_depth = Immersion_depth;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Immersion depth: " + Immersion_depth);
        }

        public override void Say()
        {
            base.Say();

            Console.Write(" blu blu,");
        }
    }



    class Mammal : Animal
    {
        public bool Presence_of_hair { get; set; }

        public Mammal() : base()
        {
            this.Presence_of_hair = true;
        }

        public Mammal(string name, string kind, bool Presence_of_hair) : base(name, kind)
        {
            this.Presence_of_hair = Presence_of_hair;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Presence of hair: " + (Presence_of_hair ? "yes" : "no"));
        }

        public override void Say()
        {
            base.Say();

            Console.Write(" bhu bhu,");
        }

    }


    sealed class Bear : Mammal
    {
        public bool Presenc_of_clicks { get; set; }
        public Bear() : base() 
        {
            Presenc_of_clicks = true;
        }

        public Bear(string name, string kind, bool Presence_of_hair, bool Presenc_of_clicks) : base(name, kind, Presence_of_hair)
        {
            this.Presenc_of_clicks = Presenc_of_clicks;
        }

        public sealed override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Presenc of clicks: " + (Presenc_of_clicks ? "yes" : "no"));
            Console.WriteLine();
        }

        public sealed override void Say()
        {
            base.Say();

            Console.WriteLine(" I'm a bear");
        }


    }




    sealed class Frog : Reptile
    {
        public bool Toxicity { get; set; }
        public Frog() : base() 
        {
            Toxicity = true;
        }

        public Frog(string name, string kind, bool Toxicity, int Temperature) : base(name, kind, Temperature)
        {
            this.Toxicity = Toxicity;
        }

        public sealed override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Toxicity: " + (Toxicity ?"yes":"no"));
            Console.WriteLine();
        }

        public sealed override void Say()
        {
            base.Say();

            Console.WriteLine(" I'm a Frog");
        }


    }



    sealed class Dolphin : Mammal
    {
        public bool Presence_of_an_echo_locator { get; set; }

        public Dolphin() : base()
        {
            Presence_of_an_echo_locator = true;
        }

        public Dolphin(string name, string kind, bool Presence_of_an_echo_locator, bool Presence_of_hair) : base(name, kind, Presence_of_hair)
        {
            this.Presence_of_an_echo_locator = Presence_of_an_echo_locator;
        }

        public sealed override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Presence of an echo locator: " + (Presence_of_an_echo_locator ? "yes" : "no"));
            Console.WriteLine();
        }

        public sealed override void Say()
        {
            base.Say();

            Console.WriteLine(" I'm a  Dolphin");
        }


    }


    sealed class Сarp : Fish
    {
        public bool Presence_of_chishui { get; set; }

        public Сarp() : base()
        {
            Presence_of_chishui = true;
        }

        public Сarp(string name, string kind, bool Presence_of_chishui, int Immersion_depth) : base(name, kind, Immersion_depth)
        {
            this.Presence_of_chishui = Presence_of_chishui;
        }

        public sealed override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Presence of chishui: " + (Presence_of_chishui ? "yes" : "no"));
            Console.WriteLine();
        }

        public sealed override void Say()
        {
            base.Say();

            Console.WriteLine(" I'm a  Сarp");
        }


    }



    sealed class Eagle : Bird
    {
        public bool Presence_of_a_beak { get; set; }

        public Eagle() : base()
        {
            Presence_of_a_beak = true;
        }

        public Eagle(string name, string kind, bool Presence_of_a_beak, float Wingspan) : base(name, kind, Wingspan)
        {
            this.Presence_of_a_beak = Presence_of_a_beak;
        }

        public sealed override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Presence of a beak " + (Presence_of_a_beak ? "yes" : "no"));
            Console.WriteLine();
        }

        public sealed override void Say()
        {
            base.Say();

            Console.WriteLine(" I'm a  Eagle");
        }


    }

    class Zoo : Animal
    {
        private Animal[] zoo;

        public Zoo()
        {
            zoo = new Animal[]
            {

             new Bear("frov","Mammal",true,true),
             new Frog("flafi","Reptile",false,20),
             new Dolphin("stiv","Mammal",true, false),
             new Сarp("clerk","fish",true, 1000),
             new Eagle("krovli","Bird",true,23)

           };
        }

        public void Show_info_zoo()
        {

            foreach (var item in zoo)
            {
                item.Show_info();
            }
        }

        public  void Show_animal_say()
        {

            foreach (var item in zoo)
            {
                item.Say();
            }
        }

    }





    class Program
    {


        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();


            zoo.Show_info_zoo();

            zoo.Show_animal_say();

        }


    }
}
