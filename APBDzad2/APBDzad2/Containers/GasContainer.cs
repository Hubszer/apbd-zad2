using APBDzad2.Exeptions;
using APBDzad2.Interfaces;

namespace APBDzad2.Containers;

public class GasContainer : Container,IHazardNotifier
{
    public double pressure { get; set; }
    
    public GasContainer(double cargoWeight, double height, double weight, double depth, string serNumb, double maxLoad,double pressure) : base(cargoWeight, height, weight, depth, serNumb, maxLoad)
    {
        this.pressure = pressure;
    }

    public override void Load(double weight)
    {
        throw new NotImplementedException();
    }

    public override void Unload()
    {
        cargoWeight *= 0.05;
    }

    public void CheckCargo()
    {
        if (maxLoad < (cargoWeight+weight))
        {
            throw new OverfillException();
        }
    }
    
    public void NotifyDanger(string serNumb)
    {
        Console.WriteLine("Danger in gas container:" + serNumb);
    }
}