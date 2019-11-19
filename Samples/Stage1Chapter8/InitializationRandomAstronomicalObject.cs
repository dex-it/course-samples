using System;

namespace Stage1Chapter8
{
    public class InitializationRandomAstronomicalObject
    {
        private readonly Random _rnd = new Random();
        public string MakeName()
        {
            var name = "";
            while (name.Length < 10)
            {
                //97, 122 - англ. алфавит
                //1040, 1104 - русс. алфавит
                var ch = (char)(_rnd.Next(97,122));
                name += ch;
            }
            return name;
        }

        public long MakeWeight()
        {
            return _rnd.Next(0, 10000000);
        }

        public bool MakeLightEmission()
        {
            return Convert.ToBoolean(_rnd.Next(0, 2));
        }
    }
}