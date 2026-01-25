using System;
using System.Runtime.CompilerServices;
class oppos
{
    string color="red";

    public string model;
    public string color;
    public int year;


    public oppos(String modelName,string modelColor,int modelYear)
    {
        model=modelName;
        color=modelColor;
        year=modelYear;
    }
    static void Main(String[]args)
    {
        oppos obj=new oppos();
        oppos obj1=new oppos("Mustang","blue",2020);
        Console.WriteLine(obj1.model);
        Console.WriteLine(obj.color);
    }
}