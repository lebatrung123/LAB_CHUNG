public class Square : Rectangle
{
    private double side ;
    public Square()
    {
    }

    public Square(double side) : base(side, side)
    {
        this.side=side;
    }

    public Square(double side, string color, bool filled) : base(side, side, color, filled)
    {
        this.side=side;

    }

    public double GetSide(){
        return GetWidth();
    }

    public void SetSide(double side){
        SetWidth(side);
        SetHeight(side);
}
    public override void SetHeight(double height)
    {
        SetSide(height);
    }
    public override void SetWidth(double width)
    {
       SetSide(width);
    }

    public override string ToString()
    {
        return "A Square with side " + " " +GetSide() + " " + "which is subclass of " + " "+ base.ToString();
    }
}
