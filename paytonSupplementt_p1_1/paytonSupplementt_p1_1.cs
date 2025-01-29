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

    /// <summary>
    /// Returns the area of a unit circle.
    /// </summary>
    /// <param name="radius">Length of the radius.</param>
    /// <returns>The area of a circle with a given radius.</returns>
    public static double AreaOfCircle(double radius)
    {
        return double.Pow(radius, 2) * double.Pi;
    }

    /// <summary>
    /// Returns the are of a triangle.
    /// </summary>
    /// <param name="triBase">Length of the triangle's base.</param>
    /// <param name="triHeight">Length of the triangle's height</param>
    /// <returns>The are of a triangle with a given base and height.</returns>
    public static double AreaOfTriangle(double triBase, double triHeight)
    {
        return triBase * triHeight / 2;
    }


}

