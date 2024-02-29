namespace Task2;

public class Airplane:Transport
{ 
    public int CountOfEngine { get; set; }
public Airplane(string model,double weight,double length, string color,string vinCode,int horsePower,int countOfEngine):
base(model,weight,length,color,vinCode,horsePower)
{
   CountOfEngine=countOfEngine; 
} 

List<Airplane>_samolyot=new List<Airplane>(); 

public void Add(Airplane airplane)
{
    _samolyot.Add(airplane);
}
public List<Airplane> GetAll()
{
    return _samolyot;
} 
}
