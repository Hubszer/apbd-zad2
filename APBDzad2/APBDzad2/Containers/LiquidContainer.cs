using APBDzad2.Exeptions;
using APBDzad2.Interfaces;

namespace APBDzad2.Containers;

public class LiquidContainer : Container,IHazardNotifier
{
   
    public LiquidContainer(string serNumb,double cargoWeight, double height, double weight, double depth, double maxLoad) : base(serNumb, cargoWeight, height, weight, depth, maxLoad)
    {
    }

    public override void Load(double weight)
    {
        CheckMaxCargo(weight);
        cargoWeight += weight;
    }

    public override void Unload()
    {
        cargoWeight = 0;
    }

    public void NotifyDanger(string serNumb)
    {
        Console.WriteLine("Danger in liquid container: " + serNumb);
    }
}