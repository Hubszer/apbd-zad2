using System.ComponentModel;
using APBDzad2.Exeptions;
using APBDzad2.Interfaces;

namespace APBDzad2.Containers;

public class CoolingContainer : Container
{
    public string product { get; private set; }
    public double temperature { get; private set; }
    
    public PossibleProducts PossibleProducts { get; set; }


    public CoolingContainer(string serNumb,double cargoWeight, double height, double weight, double depth, double maxLoad,PossibleProducts PossibleProducts) : base(serNumb, cargoWeight, height, weight, depth, maxLoad)
    {
        this.PossibleProducts = PossibleProducts;

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
   
    Dictionary<PossibleProducts,double> products = new Dictionary<PossibleProducts, double>
    {
        { PossibleProducts.BANANAS, 13.5 },
        { PossibleProducts.CHOCOLATE, 18.0 },
        { PossibleProducts.FISH, -2.0 },
        { PossibleProducts.MEAT, -5.0 },
        { PossibleProducts.ICE_CREAM, -20.0 },
        { PossibleProducts.FROZEN_PIZZA, -15.0 },
        { PossibleProducts.CHEESE, 4.0 },
        { PossibleProducts.SAUSAGES, -3.0 },
        { PossibleProducts.BUTTER, 5.0 },
        { PossibleProducts.EGGS, 2.0 }
    };
    
}