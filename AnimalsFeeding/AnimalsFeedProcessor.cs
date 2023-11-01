using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFeeding
{
    public class AnimalsFeedProcessor : IDisposable
    {
        private List<AnimalPlace> _animalPlaces = new();

        public void AddNewAnimalPlace(AnimalPlace place)
        {
            _animalPlaces.Add(place);
            Console.WriteLine("This place added");
            place.FoodFinished += OnAnimalMessage;
        }

        public void FeedAll()
        {
            foreach (var place in _animalPlaces)
            {
                place.Feed(4); 
            }
        }

        public void Dispose()
        {
            foreach (var place in _animalPlaces)
            {
                place.FoodFinished -= OnAnimalMessage;
            }
        }

        private void OnAnimalMessage(string message, AnimalPlace place)
        {
            Console.WriteLine($"{place.AnimalName}: {message}");
        }
    }
}