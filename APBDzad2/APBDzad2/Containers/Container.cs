using APBDzad2.Exeptions;
using APBDzad2.Interfaces;
namespace APBDzad2.Containers;


public abstract class Container : IContainer
{
    public double cargoWeight { get; set; }
    public double height { get; set; }
    public double weight { get; set; }
    public double depth { get; set; }
    public string serNumb { get; set; }
    public double maxLoad { get; set; }

    protected Container(string serNumb,double cargoWeight, double height, double weight, double depth, double maxLoad)
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

    public void CheckMaxCargo(double weight)
    {
        if (maxLoad < cargoWeight + weight)
        {
            throw new OverfillException();
        }
    }

    
}
    