using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Александр", new WiredPhone());
            User user2 = new User("Сергей", new CellPhone());

            user1.MyPhone.Call(333333);
            user1.MyPhone.Ring(999999);

            user2.MyPhone.Call(555555);
            user2.MyPhone.Ring(222222);

            Console.ReadLine();

        }
    }
}
