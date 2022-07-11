namespace ClassLibrary2
{
    public class Circle
    {
        private double square;
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            Calculate_area(this.radius);
        }

        private void Calculate_area(double radius)
        {
            double radius_squared = radius * radius;
            square = radius_squared * Math.PI;  
        }
       
    }
}