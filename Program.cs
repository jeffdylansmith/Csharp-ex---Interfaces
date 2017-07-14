using System;
using System.Linq;
using System.Collections.Generic;

public interface IVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
}
public interface IDriving
{
    double MaxLandSpeed { get; set; }
    void Drive();
}
public interface IFlying
{
    bool Winged { get; set; }
    double MaxAirSpeed { get; set; }
    void Fly();
}
public interface IMaritime
{
    double MaxWaterSpeed { get; set; }
    void Drive();
}
//boats
public class JetSki : IVehicle, IMaritime
{
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
    public void Drive()
    {
        Console.WriteLine("I am driving on water");
    }

}
public class Yacht : IVehicle, IMaritime
{
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
     public void Drive()
    {
        Console.WriteLine("I am driving on water");
    }
}
//road
public class Motorcycle : IVehicle, IDriving
{
    public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("I am driving");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Car : IVehicle, IDriving
{
    public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("I want to driver now");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
//air
public class Cessna : IVehicle, IFlying
{
    public bool Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Fly()
    {
        Console.WriteLine("NotImplementedException");
    }   

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Helicopter : IVehicle, IFlying
{
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Fly()
    {
        Console.WriteLine("Here we go");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Program
{
    public static void Main() {

        // Build a collection of all vehicles that fly
        Cessna dylan = new Cessna();
        Helicopter cat  = new Helicopter();
        List<IFlying> flying = new List<IFlying>();
            flying.Add(dylan);
            flying.Add(cat);
        // With a single `foreach`, have each vehicle Fly()
        foreach (var thing in flying){
            thing.Fly();
        };


        // Build a collection of all vehicles that operate on roads
        Motorcycle heidi = new Motorcycle();
        Car spradlin  = new Car();
        List<IDriving> driving = new List<IDriving>();
            driving.Add(heidi);
            driving.Add(spradlin);
        // With a single `foreach`, have each road vehicle Drive()
        foreach (var thing2 in driving){
            thing2.Drive();
        };


        // Build a collection of all vehicles that operate on water
        JetSki edward = new JetSki();
        Yacht jerry  = new Yacht();
        List<IMaritime> sailing = new List<IMaritime>();
            sailing.Add(edward);
            sailing.Add(jerry);
        // With a single `foreach`, have each water vehicle Drive()
        foreach (var thing3 in sailing){
            thing3.Drive();
        };
    }
}