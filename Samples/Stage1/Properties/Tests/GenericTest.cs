using System;
using NUnit.Framework;

namespace Stage1
{
    public class GenericTest
    {
        #region object

        [Test]
        public void ObjectTest()
        {
            var socialNetwork = new SocialNetwork();
            socialNetwork.SocialId = 5;
            socialNetwork.SocialId = "qwert";
            socialNetwork.SocialId = Guid.NewGuid();
        }

        [Test]
        public void ObjectTestBoxing()
        {
            var socialNetwork = new SocialNetwork();
            socialNetwork.SocialId = 5; // упаковка значения int в тип Object
            var socialId = (int) socialNetwork.SocialId; // Распаковка в тип int
        }

        [Test]
        public void ObjectTestException()
        {
            var socialNetwork = new SocialNetwork();
            socialNetwork.SocialId = "qwert";
            int socialId;
            Assert.Throws<InvalidCastException>(() => socialId = (int) socialNetwork.SocialId);
        }

        class SocialNetwork
        {
            public Guid Id { get; set; }
            public Guid UserId { get; set; }
            public object SocialId { get; set; }
            public string SocialType { get; set; }
        }

        #endregion
        
        class SocialNetwork<T>
        {
            public Guid Id { get; set; }
            public Guid UserId { get; set; }
            public T SocialId { get; set; }
            public string SocialType { get; set; }
        }

        [Test]
        public void Test()
        {
            var socialNetworkInt = new SocialNetwork<int>();
            socialNetworkInt.SocialId = 5; // упаковка больше не нужна
            int socialId1 = socialNetworkInt.SocialId; // распаковка больше не нужна
 
            var socialNetworkString = new SocialNetwork<string>();
            socialNetworkString.SocialId = "qwert";
        }

        [Test]
        public void CompilationError()
        {
            var socialNetworkString = new SocialNetwork<string>();
            socialNetworkString.SocialId = "qwert";
            
            // ошибка компиляции
            // int socialId2 = socialNetworkString.SocialId; 
        }

        [Test]
        [TestCase(7, 30)]
        [TestCase(12, 16)]
        public void SwapIntTest(int p1, int p2)
        {
            var x = p1;
            var y = p2;
            Swap(ref x, ref y);
            Assert.AreEqual(x, p2);
            Assert.AreEqual(y, p1);
        }
        
        [Test]
        [TestCase("Hello", "How are you?")]
        [TestCase("How are you?", "Hello")]
        public void SwapStringTest(string p1, string p2)
        {
            var x = p1;
            var y = p2;
            Swap(ref x, ref y);
            Assert.AreEqual(x, p2);
            Assert.AreEqual(y, p1);
        }

        private static void Swap<T> (ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}