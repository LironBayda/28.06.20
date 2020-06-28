using System;

abstract public class  Vehice
{
    public int _numberOfWheels;
    public string _model;

    abstract public int GetMaxNumOfPassengers();
    abstract public int GetMaxNumspeed();
    override public string ToString()
    {
        return $" number Of Wheels= {_numberOfWheels} model {_model}" ;


    }

}
