using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;


namespace LegoMinifigures
{
  
    class Astronaut
    {
        //Public Property
        public Location Location { get; set; }
        //Expression Bodied Property
        public bool SuitedUp => Name == "Space Person";
        //Read Only Property
        public string Name { get; }
        //Public Property with a private setter
        public string Job { get; private set; }
        //Private Property with a public setter
        public int OxygenLevel { private get; set; }

        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public AstronautHead Head { get; set; }

        public Astronaut(string name, string job, 
                         AstronautHead head, AstronautTorso torso,
                         AstronautLegs legs)
        {
            Name = name;
            Job = job;

            Head = head;
            Legs = legs;
            Torso = torso;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob(int stepsToWalk)
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
            Legs.Walk(stepsToWalk);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(stepsToWalk);
        }
    }
}
