using System.ComponentModel;
using APBDzad2.Exeptions;

namespace APBDzad2.Containers;

public abstract class Container : IContainer
{
    private IContainer _containerImplementation;
    public double cargoWeight { get; set; }
    private double height { get; set; }
    public double weight { get; set; }
    private double depth { get; set; }
    private string serNumb { get; set; }
    public double maxLoad { get; set; }

    protected Container(double cargoWeight, double height, double weight, double depth, string serNumb, double maxLoad)
    {
        this.cargoWeight = cargoWeight;
        this.height = height;
        this.weight = weight;
        this.depth = depth;
        this.serNumb = serNumb;
        this.maxLoad = maxLoad;
    }
    public abstract void Load(double weight);
    public abstract void Unload();

    public void CheckMaxCargo()
    {
        if (maxLoad < (cargoWeight+weight))
        {
            throw new OverfillException();
        }
    }

    
}
    