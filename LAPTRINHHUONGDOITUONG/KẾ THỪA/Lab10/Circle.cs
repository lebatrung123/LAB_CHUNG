public class Circle: Shape {

private double radius=1.0;


public Circle(double radius){
this.radius=radius;
}

public Circle(){

}

public Circle(double radius,string color, bool filled ):base( color, filled){
  this.radius=radius;
}

public double GetRadius(){
 return radius;
}

public void SetRadius(){
    this.radius=radius;
}

public double GetArea(double radius){
    return radius * radius *Math.PI;
}
 public double GetPerimeter(double radius){
    return radius*2*Math.PI;
 }
    public override string ToString()
    {
        return "a circle with radius is" + " " + GetRadius() +" " + "is subclass of" +" "+ base.ToString();
    }
}