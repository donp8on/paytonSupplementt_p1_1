namespace paytonSupplementt_p1_1;

public class paytonSupplementt_p1_1
{
    /// <summary>
    /// Returms the area of a rectangle. If the length equal to the width, 
    /// the calculation is completed as length*length instead.
    /// </summary>
    /// <param name="len">Length of rectangle.</param>
    /// <param name="wid">Width of rectangle.</param>
    /// <returns>Area of the rectangle</returns>
    public static double AreaOfRect(double len, double wid)
    {
        if (len == wid) {
            return len * len;
        } else {
            return len * wid;
        }
        
    }

    public static double AreaOfCircle(double radius)
    {
        return double.Pow(radius, 2) * double.Pi;
    }

    public static double AreaOfTriangle(double triBase, double triHeight)
    {
        throw new NotImplementedException();
    }


}

