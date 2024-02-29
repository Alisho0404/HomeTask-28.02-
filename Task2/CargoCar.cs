namespace Task2;

public class CargoCar:Car
{ 
    public double CargoCapacity { get; set; }
    public CargoCar(string model,double weight,double length, string color,string vinCode,int horsePower, string wheal,int countOfStear,string whealDisc,double cargoCapacity):
    base(model,weight,length,color,vinCode,horsePower,wheal,countOfStear,whealDisc)
    {
    CargoCapacity=cargoCapacity; 
    } 
    List<CargoCar>_cargoCar=new List<CargoCar>(); 

    public void Add(CargoCar cargo)
    {
        _cargoCar.Add(cargo);
    }
    public List<CargoCar> CargoGetAll()
    {
        return _cargoCar;

    } 
}
