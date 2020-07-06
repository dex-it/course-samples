using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ConsoleApp1;

namespace _18_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //получаю тип внешнего клаксса
            Type type = Type.GetType("ConsoleApp1.SmartPhone, ConsoleApp1", true, true);

            //делаю инстанс этого класса
            object objPhoneWithCamera = Activator.CreateInstance(type);
            //получаю методы Сделать фото и переименовать фото
            MethodInfo methodMakePhoto = type.GetMethod("MakePhoto");
            MethodInfo methodRenamePhoto = type.GetMethod("RenamePhoto");

            //выполняю эти методы
            methodMakePhoto.Invoke(objPhoneWithCamera, new object[] {});
            methodRenamePhoto.Invoke(objPhoneWithCamera, new[] {"NewNameForPhoto"});

            //Получаю поле Photo внешнего класса
            var photo = type.GetProperty("Photo").GetValue(objPhoneWithCamera);
            //Получаю поле Name класса Photo
            var namePhoto = photo.GetType().GetProperty("Name").GetValue(photo);

            Console.WriteLine(namePhoto);
            Console.ReadKey();
        }
    }
}
