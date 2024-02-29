 namespace HomeTask_28._02_;

public class Smartphone:Computer
{
    private int _numberOfSelfies;
    public int NumberOfSelfies
    {
        get { return _numberOfSelfies; }
        set { _numberOfSelfies = value; }
    }
public Smartphone(int ram, int storage, string keyboard,int numberOfSelfies):base(ram,storage,keyboard)
{
   _numberOfSelfies=numberOfSelfies; 
}
    public void TakeSelfies()
    {

    }
}
