namespace Task2;

public class Transport
{
    public string Model { get; set; }

    public double Weight { get; set; } 

    public double Length { get; set; } 

    public string Color { get; set; }

    public string VinCode { get; set; }  

    public int HorsePower { get; set; }

    public Transport(string model,double weight,double length, string color,string vinCode,int horsePower)
    {
        Model=model; 
        Weight=weight; 
        Length=length;  
        Color=color;
        VinCode=vinCode;
        HorsePower=horsePower;
    } 

}
