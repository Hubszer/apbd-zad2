using System.ComponentModel;
using APBDzad2.Exeptions;
using APBDzad2.Interfaces;

namespace APBDzad2.Containers;

public abstract class CoolingContainer : Container
{
    public string product { get; private set; }
    public double temperature { get; private set; }


    public CoolingContainer(double cargoWeight, double height, double weight, double depth, string serNumb, double maxLoad, double type,string product,double temperature) : base(cargoWeight, height, weight, depth, serNumb, maxLoad)
    {
        this.product = product;
        this.temperature = temperature;

    }

    public override void Load(double weight)
    {
        cargoWeight += weight;
    }

    public override void Unload()
    {
        cargoWeight = 0;
    }
    public void CheckCargo()
    {
        if (maxLoad < (cargoWeight+weight))
        {
            throw new OverfillException();
        }
    }
    
    
}