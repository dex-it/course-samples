using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DeepCloning
{
    [Serializable]
    public class House
    {
        public int FloorCount { get; set; } = 2;
        public List<string> RoomsList = new List<string>();
        
        public House DeepCopy()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            formatter.Serialize(memStream, this);
            memStream.Flush();
            memStream.Position = 0;
            return (House)formatter.Deserialize(memStream);
        }
    }
}
