namespace Task2;

public class PassengerPlane:Airplane
{ 
 public int PassangerCapacity { get; set; }
 public PassengerPlane(string model,double weight,double length, string color,string vinCode,int horsePower,int countOfEngine,int passangerCapacity):
 base(model,weight,length,color,vinCode,horsePower,countOfEngine)
 {
    PassangerCapacity=passangerCapacity;
 } 

 List<PassengerPlane>_passangerPlane=new List<PassengerPlane>(); 

public void Add( PassengerPlane passengerPlane)
{
    _passangerPlane.Add(passengerPlane);
}
public List<PassengerPlane> PassengerPlaneGetAll()
{
    return _passangerPlane;
} 

}
