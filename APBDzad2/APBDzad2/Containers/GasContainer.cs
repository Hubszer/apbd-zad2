using APBDzad2.Exeptions;
using APBDzad2.Interfaces;

namespace APBDzad2.Containers;

public class GasContainer : Container,IHazardNotifier
{
    public double pressure { get; set; }
    
    public GasContainer(string serNumb,double cargoWeight, double height, double weight, double depth, double maxLoad,double pressure) : base(serNumb, cargoWeight, height, weight, depth, maxLoad)
    {
        this.pressure = pressure;
    }

    public override void Load(double weight)
    {
        CheckMaxCargo(weight);
        cargoWeight += weight;
    }

    public override void Unload()
    {
        cargoWeight *= 0.05;
    }
    
    public void NotifyDanger(string serNumb)
    {
        Console.WriteLine("Danger in gas container:" + serNumb);
    }
}