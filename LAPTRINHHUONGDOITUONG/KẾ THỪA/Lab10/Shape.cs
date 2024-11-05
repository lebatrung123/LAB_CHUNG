public class Shape
{

    private String color="Green" ;

    
    private bool filled=true ;

    public Shape(){

    }
    public Shape(String color, bool filled){
        this.color=color;
        this.filled=filled;
    }

    public String Getcolor(){
        return color;
    }

    public bool Getfilled(){
        return filled;
    }

    public void Setcolor(String color){
        this.color=color;
    }

    public void Setfilled(bool filled){
        this.filled=filled;
    }

    public override string ToString()
    {
        return "A Shape with color"+" " + Getcolor() + "and "+" " +Getfilled();
    }

}