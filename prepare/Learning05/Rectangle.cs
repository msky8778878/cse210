using System;
using System.Drawing;

public class Rectangle : Shape
{
    double _sideA;
    double _sideB;

    public Rectangle(string color, double sideA, double sideB) : base(color)
    {
        _sideA = sideA;
        _sideB = sideB;
    }

    public override double GetArea()
    {
        return _sideA * _sideB;
    }
}