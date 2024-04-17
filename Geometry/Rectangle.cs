namespace Geometry
{
    public class Rectangle : Polygon
    {
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Area()
        {
            int area = Width * Height;
            return area;
        }

        public int Perimeter()
        {
            int perimeter = (Width + Height) * 2;
            return perimeter;
        }

    }
}