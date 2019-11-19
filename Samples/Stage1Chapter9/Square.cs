namespace Stage1Chapter9
{
    class Square : Rectangle
    {
        private const string name = "Квадрат";
        
        protected override string Name
        {
            get
            {
                return name;
            }
        }   

        public Square(decimal height = 0):base(height, height)
        {
            
        }


    }
}
