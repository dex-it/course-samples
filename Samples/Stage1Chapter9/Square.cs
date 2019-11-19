namespace Stage1Chapter9
{
    public class Square : Rectangle
    {
        //private const string name = "Квадрат";
        
        protected override string Name => "Квадрат";

        public Square(decimal height = 0):base(height, height)
        {
            
        }


    }
}
