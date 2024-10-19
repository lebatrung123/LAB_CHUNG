public class Rectangle
{
    public float height;
    public float weight;

    public Rectangle()
    {

    }
    public Rectangle(float weight, float height)
    {
        this.weight = weight;
        this.height = height;

    }
    public float GetArea()
    {
        return weight * height;

    }
    public float GetPerimeter()
    {
        return 2 * (weight + height);

    }


}