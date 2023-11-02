using AnimalsFeeding;

using var feedProcessor = new AnimalsFeedProcessor();

var animal1 = new AnimalPlace("Tom", "Fish", 5);
var animal2 = new AnimalPlace("Jerry", "Cheese", 2);
var animal3 = new AnimalPlace("Chappie", "Bone", 3);

feedProcessor.AddNewAnimalPlace(animal1);
feedProcessor.AddNewAnimalPlace(animal2);
feedProcessor.AddNewAnimalPlace(animal3);
Console.WriteLine();

feedProcessor.FeedAll();