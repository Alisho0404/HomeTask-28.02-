namespace HomeTask_28._02_;

public class Laptop : Computer
{
    private int _weight; 

    public int Weight 
    { 
        get {   return _weight; } 
        set {   _weight = value; } 
    } 

    public Laptop(int ram, int storage, string keyboard,int weight ):base(ram,storage,keyboard) 
    {
        _weight = weight;
    }
    
    public void WeightCheck()
    {
                
    }
}
