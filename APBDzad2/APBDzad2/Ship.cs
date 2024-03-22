using APBDzad2.Exeptions;

namespace APBDzad2.Containers;

public class Ship
{
    public string name { get; set; }
    public List<Container> Containers;

    public Ship(string name,List<Container> containers, int maxSpeed, int maxContainers, double maxWeight)
    {
        this.name = name;
        Containers = containers;
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public int MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxWeight { get; set; }

   

    public void CheckMaxContainersWeight(List<Container> Containers)
    {
        double totalWeight = Containers.Sum(container => container.cargoWeight);
        if (totalWeight > MaxWeight)
        {
            throw new OverfillException();
        }
    }
    public void LoadContainer(Container container)
    {
        if (Containers.Count < MaxContainers)
        {
            Containers.Add(container);
        }
        else
        {
            Console.WriteLine("cant load more containers");
        }
    }

    public void LoadContainersToShip(List<Container> containerList)
    {
        foreach (var container in containerList)
        {
            LoadContainer(container);
        }   
        CheckMaxContainersWeight(containerList);
    }
    
    public void UnloadContainer(Container container)
    {
        container.Unload();
    }

    public void ReplaceContainers(Container c1,Container c2)
    {
        int i = Containers.IndexOf(c1);
        if (i != -1)
        {
            Containers[i] = c2;
        }
    }

    public void RemoveContainer(Container container)
    {
        Containers.Remove(container);
    }

    public void TransferContainer(Container container,Ship ship)
    {
        RemoveContainer(container);
        ship.LoadContainer(container);
        CheckMaxContainersWeight(Containers);
    }

    public void ShipInfo(Ship ship)
    {
        Console.WriteLine($"Ship info:");
        Console.WriteLine($"Max speed: {ship.MaxSpeed}");
        Console.WriteLine($"Max containers: {ship.MaxContainers}");
        Console.WriteLine($"Max weight: {ship.MaxWeight}");
        Console.WriteLine($"Current containers: {ship.Containers.Count}");
        
    }
    public void ContainerInfo(Container container)
    {
        Console.WriteLine($"Container info:");
        Console.WriteLine($"Container number: {container.serNumb}");
        Console.WriteLine($"Load weight: {container.cargoWeight}");
        Console.WriteLine($"Max weight: {container.maxLoad}");
        Console.WriteLine($"Height: {container.height}");
        Console.WriteLine($"Depth: {container.depth}");
        Console.WriteLine($"Weight: {container.weight}");
    }
}