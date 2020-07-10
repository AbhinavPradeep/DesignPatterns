using System;

public sealed class SomeExpensiveResource
{
    private static readonly Lazy<SomeExpensiveResource> lazy = 
        new Lazy<SomeExpensiveResource>(() => new SomeExpensiveResource());
    public static SomeExpensiveResource Instance { get { return lazy.Value; } }

    private SomeExpensiveResource()
    {
        System.Console.WriteLine($"An expensive resource has been created {this.GetHashCode()}");
    }

    public void UseExpensiveResource()
    { 
        System.Console.WriteLine($"The expensive resource is being used - {this.GetHashCode()}");
    }
}