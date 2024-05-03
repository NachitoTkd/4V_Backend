using System;
public class Rectangulo : Figura
{
    public double BaseR { get; set; }
    public double AlturaR { get; set; }

    public Rectangulo(double baseR, double alturaR)
    {
        BaseR = baseR;
        AlturaR = alturaR;
    }

    public override double CalcularArea()
    {
        return BaseR * AlturaR;
    }
}