using System;

public class Car:Vehice
{
    const int MAX_NUM_SPEED = 200;
    const int NUM_OF_PASSENGERS = 5;


    public int _numberOfDoors;
    override public int GetMaxNumOfPassengers()
    {
        return NUM_OF_PASSENGERS;
    
    }
    override public int GetMaxNumspeed()

    {
        return MAX_NUM_SPEED;
    }
    override public string ToString()
    {
        return base.ToString() + $" numberOfDoors= {_numberOfDoors}";


    }
}
