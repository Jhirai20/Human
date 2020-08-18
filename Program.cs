using System;

namespace Human
{
    class Human
    {
        //Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        //add a public "getter" property to access health
        public int Health 
        {
            get { return health;}
            set {health = value;}
        }

        //add a constructor that takes a value to set Name, and set the remaing fields to default values
        public Human (string name)
        {
            Name=name;
            Strength=3;
            Intelligence=3;
            Dexterity=3;
            health=100;
        }
        //add a constructor to assign custom values to all fields (this one modifies target name)
        public Human (string name, int strength, int intelligence,int dexterity, int health) :this(name)
        {
            Strength=strength;
            Intelligence=intelligence;
            Dexterity=dexterity;
            Health=health;
        }

        //build attack method
        public void Attack (Human target)
        {
            var Target = (Human) target;
            Target.Health -=5*Strength;
            Console.ForegroundColor =ConsoleColor.Red;
            Console.WriteLine($"ATTACKING!! {Target.Name} loses {5*Strength} from health");
            Console.WriteLine("Target Stats: "+Target.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Strength:{Strength}, Intelligence: {Intelligence}, Dexterity {Dexterity}, Health {Health}";
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Human("Jeff");
            var player2 = new Human("Chris")   ;
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            player2.Attack(player1);

        }
    }
}
