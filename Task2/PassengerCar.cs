namespace Task2;

public class PassengerCar:Car
{ 
    public int PassengerCapacity { get; set; }
    public PassengerCar(string model,double weight,double length, string color,string vinCode,int horsePower, string wheal,
    int countOfStear,string whealDisc,int passengerCapacity)
    :base(model,weight,length,color,vinCode,horsePower,wheal,countOfStear,whealDisc)
    {
    PassengerCapacity=passengerCapacity;  
    } 
    List<PassengerCar>_pasengercar=new List<PassengerCar>(); 

    public void Add(PassengerCar passenger)
    {
        _pasengercar.Add(passenger);
    }
    public List<PassengerCar> PassengerGetAll()
    {
        return _pasengercar;

    }
}