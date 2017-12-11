using System;

abstract class ContinentFactory
  {
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
  }
//Knows how to create products
class AmericaFactory : ContinentFactory
{
    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }

    public override Herbivore CreateHerbivore()
    {
        return new Wildebeest();
    }
}
//Concretely implementing behaviours to return product
class AfricaFactory : ContinentFactory
{
   public override Herbivore CreateHerbivore()
    {
      return new Bison();
    }
    public override Carnivore CreateCarnivore()
    {
      return new Wolf();
    }
}

abstract class Carnivore
{
    public abstract void Eat(Herbivore h);
}

abstract class Herbivore
{
}

class Lion : Carnivore
{
        public override void Eat(Herbivore h)
    {
         Console.WriteLine(this.GetType().Name +" eats " + h.GetType().Name);
    }
}

class Wolf : Carnivore
{
    public override void Eat(Herbivore h)
    {
        Console.WriteLine(this.GetType().Name +" eats " + h.GetType().Name);
    }
}

class Bison :Herbivore
{

}

class Wildebeest : Herbivore
{

}

//Client know about all abstract animals (product) and continent (factory)
class AnimalWorldClient
{
    private Herbivore _herbivore;
    private Carnivore _carnivore;
     public AnimalWorldClient(ContinentFactory factory)
    {
      _carnivore = factory.CreateCarnivore();
      _herbivore = factory.CreateHerbivore();
    }

     public void RunFoodChain()
    {
      _carnivore.Eat(_herbivore);
    }
}