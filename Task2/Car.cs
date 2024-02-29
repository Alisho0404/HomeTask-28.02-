namespace Task2;

 public class Car:Transport
{
public string Wheal { get; set; } 

public int CountOfStear { get; set; } 

public string WhealDisc { get; set; } 

public Car(string model,double weight,double length, string color,string vinCode,int horsePower, string wheal,
int countOfStear,string whealDisc):base(model,weight,length, color,vinCode,horsePower)
{
    Wheal=wheal; 
    CountOfStear=countOfStear; 
    WhealDisc=whealDisc;
}  
List<Car>_moshin=new List<Car>(); 

public void Add(Car car)
{
    _moshin.Add(car);
}
public List<Car> GetAll()
{
    return _moshin;
} 

}
