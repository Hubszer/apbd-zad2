
using APBDzad2;
using APBDzad2.Containers;




CoolingContainer coolingcontainer = new CoolingContainer("KON-C-1", 2021.2, 15, 200, 10, 2500, PossibleProducts.EGGS);
LiquidContainer liquidcontainer = new LiquidContainer("KON-C-2", 2011.2, 15, 200, 10, 2400);
GasContainer gascontainer = new GasContainer("KON-C-3", 2021.2, 15, 200, 10, 2500, 1024);

List<Container> containersList = new List<Container>();

containersList.Add(coolingcontainer);
containersList.Add(liquidcontainer);
containersList.Add(gascontainer);



var ship = new Ship("F1",containersList,78,2000,450000000);


ship.RemoveContainer(coolingcontainer);

ship.ShipInfo(ship);

ship.ContainerInfo(gascontainer);
//ArrayList
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
//Set
HashSet<int> set = new();
//Map

