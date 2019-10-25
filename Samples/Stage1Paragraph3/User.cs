using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph3
{
    class User
    {
        public User(string name, Phone phone )
        {
            Name = name;
            MyPhone = phone;
        }

        public string Name { get; set; }

        public Phone MyPhone { get; set; }
    }
}
