using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFeeding
{
    public class AnimalPlace
    {
        private int _foodAmount;

        public string AnimalName { get; set; }
        
        public string FoodName { get; set; }

        public event Action<string, AnimalPlace>? FoodFinished;

        public AnimalPlace(string animalName, string foodName, int initialFoodAmount)
        {
            AnimalName = animalName;
            FoodName = foodName;
            _foodAmount = initialFoodAmount;
        }

        public void Feed(int amount)
        {
            if (amount >= _foodAmount)
            {
                Console.WriteLine($"Feeding {AnimalName} with {_foodAmount} {FoodName}.");
            }
            else FoodFinished?.Invoke("Food is out", this);
        }
    }
}