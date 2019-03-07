using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;
         
        // add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Steak au Poivre", 700, true, false),
                new Food("Coquilles St. Jacques", 450, false, false),
                new Food("Homard a la Vanille", 500, false, false),
                new Food("Cotes d'Agneau", 625, false, false),
                new Food("Ris de Veau", 550, false, false),
                new Food("Moules Mariniere", 300, false, false),
                new Food("Foie Gras au Torchon", 250, false, false),
                new Food("Mousse au Chocolat", 800, false, true),
                new Food("Creme Brulee", 1000, false, true),
                new Food("Gratin de Fraises", 500, false, true),
            };
        }
        // build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object         
        public Food Serve()
        {
            Random rand = new Random();
            int randIdx = rand.Next(Menu.Count);
            Console.WriteLine($"Serving up some {Menu[randIdx].Name}!");
            return Menu[randIdx];
        }
    }
    
    class Ninja
    {
        string Name = "The Ninja";
        private int calorieIntake;
        public List<Food> FoodHistory;
         
        // add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public Ninja(string name)
        {
            Name = name;
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
         
        // add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
         
        // build out the Eat method that: if the Ninja is NOT full
        // adds calorie value to ninja's total calorieIntake
        // adds the randomly selected Food object to ninja's FoodHistory list
        // writes the Food's Name - and if it is spicy/sweet to the console
        // if the Ninja IS full
        // issues a warning to the console that the ninja is full and cannot eat anymore
        public void Eat(Food item)
        {
            if (IsFull)
            {
                Console.WriteLine($"{Name} is full and cannot eat anymore... :(");
            }
            else
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                if (item.IsSpicy)
                {
                    Console.WriteLine($"{item.Name} is spicy!!!");
                }
                else if (item.IsSweet)
                {
                    Console.WriteLine($"{item.Name} is sweet and yummy!!! ;D");
                }
                else
                {
                    Console.WriteLine($"{item.Name} is delicious... :P");

                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ninja Nina = new Ninja("Nina");
            Buffet FrenchBistro = new Buffet();
            Nina.Eat(FrenchBistro.Serve());
            Nina.Eat(FrenchBistro.Serve());
            Nina.Eat(FrenchBistro.Serve());
            Nina.Eat(FrenchBistro.Serve());
            Nina.Eat(FrenchBistro.Serve());
            Nina.Eat(FrenchBistro.Serve());
            Nina.Eat(FrenchBistro.Serve());
            Nina.Eat(FrenchBistro.Serve());
        }
    }
}
