public class Fan()
{

 public const int Slow=1,medium=2,fast=3;
  
 
 private int speed=Slow;
 private bool on=false;
 
 private double radius=5;
 private string color="blue";
 
 public int Speed{
   get{return speed;}
   set{speed=value;}
 }

 public bool On{
   get{return on;}
   set{on=value;}
 }

 public double Radius{
    get{return radius;}
    set{radius=value;}
 }
 public string Color{
    get{return color;}
    set{color=value;}
 }
 public Fan(int speed, bool on, double radius, string color){
     
 }
public Fan()
  {
     
}

public override string ToString(){
  if(on==true){
    return "Fan is on";
  }else{
    return "Fan is of";
  }
}

}




