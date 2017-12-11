using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
                    // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorldClient world = new AnimalWorldClient(africa);
            world.RunFoodChain();
        
            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorldClient(america);
            world.RunFoodChain();
        
            // Wait for user input
            Console.Read();    
        }
    }
}
