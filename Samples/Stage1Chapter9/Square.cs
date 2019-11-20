namespace Stage1Chapter9
{
    public class Square : Rectangle
    {
        protected override string Name => "Квадрат";

        public Square(decimal height = 0):base(height, height)
        {
            
        }


    }
}
