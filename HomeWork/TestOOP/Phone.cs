using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Phone
    {
        public string Model { get; set; }
        public string Price { get; set; }

        public void Call(string number)
        {
            Dialing(number);
        }

        private void Dialing(string number) { }
    }

    public class PhoneWithCamera : Phone
    {
        public Photo Photo { get; set; }
        public void MakePhoto()
        {
            Photo photo = GetPhoto();
            SavePhoto(photo);
        }
        private Photo GetPhoto()
        {
            return new Photo();
        }
        private void SavePhoto(Photo photo)
        {
            Photo = photo;
        }

    }

    public class SmartPhone : PhoneWithCamera
    {
        public void RenamePhoto(string newName)
        {
            Photo.Name = newName;
        }
    }

    public class Photo
    {
        public string Name { get; set; }
        public double Size
        {
            get { return (Height * Weight)/1024; }
        }

        public int Height { get; set; }
        public int Weight { get; set; }
        public Photo()
        {
            Name = "Photo("+DateTime.Now.ToString()+")";
            Height = 1080;
            Weight = 1920;
        }

    }
}
