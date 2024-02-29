namespace Task2;

public class CargoPlane:Airplane
{ 
    public double LiftingCapacity { get; set; }
public CargoPlane(string model,double weight,double length, string color,string vinCode,int horsePower,int countOfEngine,double liftingCapacity):
base(model,weight,length, color,vinCode,horsePower,countOfEngine)
{
   LiftingCapacity=liftingCapacity; 
} 

List<CargoPlane>_cargoPlane=new List<CargoPlane>(); 

public void Add(CargoPlane cargoPlane)
{
    _cargoPlane.Add(cargoPlane);
}
public List<CargoPlane> CargoGetAll()
{
    return _cargoPlane;
} 

}
