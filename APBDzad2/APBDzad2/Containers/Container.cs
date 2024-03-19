using System.ComponentModel;
using APBDzad2.Exeptions;

namespace APBDzad2.Containers;

public abstract class Container : IContainer
{
    public double cargoWeight { get; set; }
    private double height{ get; set; }
    private double weight{ get; set; }
    private double depth{ get; set; }
    private string serNumb{ get; set; }
    private static int numb;
    private double maxLoad{ get; set; }

    protected Container(double cargoWeight, double height, double weight, double depth, string serNumb, double maxLoad, double type)
    {
        this.cargoWeight = cargoWeight;
        this.height = height;
        this.weight = weight;
        this.depth = depth;
        this.serNumb = serNumb;
        this.maxLoad = maxLoad;
        Type = type;
    }

    public double Type { get; set; }

    public void removeLoadMass()
    {
        cargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        weight =+ cargoWeight;

        if (maxLoad > weight)
        {
            throw new OverfillException();
        }

        Console.WriteLine("waga w porzadku");
    }

    public void isBiggerMass()
    {
        if (loadMass > maxLoad)
        {
            throw new Exception("OverfillException");
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Add(IComponent? component)
    {
        throw new NotImplementedException();
    }

    public void Add(IComponent? component, string? name)
    {
        throw new NotImplementedException();
    }

    public void Remove(IComponent? component)
    {
        throw new NotImplementedException();
    }

    public ComponentCollection Components { get; }
}