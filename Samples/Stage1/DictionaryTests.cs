using System.Collections.Generic;
using NUnit.Framework;

namespace Stage1
{
    public class DictionaryTests
    {
        [Test]
        public void Test()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            {
                {"77712345", "Иванов И.И"},
                {"77812345", "Петров П.П"},
                {"77912345", "Сидоров С.С"}
            };
  
            phoneBook.Add("77512345", "Васильев В.В");
            phoneBook["77412345"] = "Алексеев А.А"; // если ключ "77412345" уже есть в словаре, то произойдёт обновление, если нет - вставка.
            phoneBook.Remove("77712345");
            
            Assert.IsTrue(phoneBook.ContainsKey("77512345"));
            Assert.IsFalse(phoneBook.ContainsKey("77712345"));
            Assert.AreEqual(phoneBook["77812345"], "Петров П.П");
        }
    }
}