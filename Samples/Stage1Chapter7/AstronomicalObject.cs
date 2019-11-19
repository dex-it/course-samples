namespace Stage1Chapter7
{
    class AstronomicalObject
    {
        public string Name { get; }
        public bool LightEmission { get; }
        public AstronomicalObject(string name = "No name", bool lightEmission = false)
        {
            Name = name;
            LightEmission = lightEmission;
        }

    }
}
