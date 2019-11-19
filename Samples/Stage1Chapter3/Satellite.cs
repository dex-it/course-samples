namespace Stage1Chapter3
{
    class Satellite: AstronomicalObject
    {
        protected bool LightEmission => false;

        public Satellite(string satelliteName):base(satelliteName)
        {
            
        }
    }
}
