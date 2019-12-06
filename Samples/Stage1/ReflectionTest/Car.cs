namespace Stage1.ReflectionTest
{
    public  class Car
    {
        public Car()
        {
            
        }
        
        public Car(string name, string number)
        {
            Name = name;
            Number = number;
        }
        
        public string Name { get; set; }
       
        public string Number { get; set; }
       
        private static string testPrivateProp { get; set; }="testValue";
        //private  string TestClosedProp { get; set; }="testValue";

        
        public void Start()
        {
            
        }
        
    }
}