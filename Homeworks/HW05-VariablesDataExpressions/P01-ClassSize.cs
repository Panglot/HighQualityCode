public class Size
{
    public double width;
    public double height;

    public Size(double w, double h)
    {
        this.width = w;
        this.height = h;
    }
    
    public static Size GetRotatedSize(Size size, double RotationAngle)
    {
        double ResultingWidth = Math.Abs(Math.Cos(RotationAngle)) * size.width +
                Math.Abs(Math.Sin(RotationAngle)) * size.height;
        double ResultingHeight = Math.Abs(Math.Sin(RotationAngle)) * size.width +
                Math.Abs(Math.Cos(RotationAngle)) * size.height;

        Size ResultingSize = new Size(ResultingWidth, ResultingHeight);

        return ResultingSize;
    }
}