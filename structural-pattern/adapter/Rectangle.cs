namespace adapter{

    public class Rectangle : VectorObject{

        public Rectangle(int x, int x, int width, int height ){

            Add(new Line(new Point(x , y), new Point(x + width, y)));
            Add(new Line(new Point(x + width , y), new Point(x + width, y + height)));
            Add(new Line(new Point(x , y), new Point(x + width, y)));            
            Add(new Line(new Point(x , y), new Point(x + width, y)));
        }

    }

}