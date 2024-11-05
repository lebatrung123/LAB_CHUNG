public class Rectangle: Shape {
    private double width=1.0;
    private double height=1.0;

    public Rectangle(){

    }

    public Rectangle(double width, double height){
        this.height=height;
        this.width=width;
    }
    public Rectangle(double width, double height, string color, bool filled):base(color,filled){
        this.height=height;
        this.width=width;
    }

    public double GetHeight(){
        return height;
    }

    virtual public void SetHeight(double height){
        this.height=height;
    }
   
      public double GetWidth(){
        return width;
    }
 virtual public void SetWidth(double width){
        this.width=width;
    }

    public override string ToString()
    {
        return "A rectangle with width: " + GetWidth()+"lenght=" + GetHeight() +"which is subclass of " + ToString();
    }
}