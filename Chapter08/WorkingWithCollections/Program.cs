using System.Collections.Immutable;

// Simple syntax for creating a list and adding three items
List<string> cities = new();
cities.Add("London");
cities.Add("Paris");
cities.Add("Milan");
/* Alternative syntax that is converted by the compiler into
 the three Add method calls above
List<string> cities = new()
 { "London", "Paris", "Milan" }; */
/* Alternative syntax that passes an 
 array of string values to AddRange method
List<string> cities = new(); 
cities.AddRange(new[] { "London", "Paris", "Milan" }); */
Output("Initial list", cities);
WriteLine($"The first city is {cities[0]}.");
WriteLine($"The last city is {cities[cities.Count - 1]}.");
cities.Insert(0, "Sydney");
Output("After inserting Sydney at index 0", cities);
cities.RemoveAt(1);
cities.Remove("Milan");
Output("After removing two cities", cities);

PriorityQueue<string, int> vaccine = new();
// add some people
// 1 = high priority people in their 70s or poor health
// 2 = medium priority e.g. middle-aged
// 3 = low priority e.g. teens and twenties
vaccine.Enqueue("Pamela", 1); // my mum (70s)
vaccine.Enqueue("Rebecca", 3); // my niece (teens)
vaccine.Enqueue("Juliet", 2); // my sister (40s)
vaccine.Enqueue("Ian", 1); // my dad (70s)
OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
WriteLine("Adding Mark to queue with priority 2");
vaccine.Enqueue("Mark", 2); // me (40s)
WriteLine($"{vaccine.Peek()} will be next to be vaccinated.");
OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);

ImmutableList<string> immutableCities = cities.ToImmutableList();
ImmutableList<string> newList = immutableCities.Add("Rio");
Output("Immutable list of cities:", immutableCities); 
Output("New list of cities:", newList); 