namespace Task2;

public class Train:Transport
{ 
    public int CountOfVagon { get; set; }
    public Train(string model,double weight,double length, string color,string vinCode,int horsePower,int countOfVagon):
    base(model,weight,length,color,vinCode,horsePower)
    {
    CountOfVagon=countOfVagon; 
    } 

    List<Train>_train=new List<Train>(); 

    public void Add(Train train)
    {
        _train.Add(train);
    }
    public List<Train> GetAll(Train train)
    {
        return _train;
    } 

}
