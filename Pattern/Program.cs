// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


public interface IComponent
{
    public void Operation();
}

public class ConcreteComponent  : IComponent
{
    public void Operation() => Console.Write("Concretecomponent");
}