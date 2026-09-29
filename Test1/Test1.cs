using SzyfrCezara;

namespace Test1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cezar cezar = new Cezar();
            string tekstJawny = "abc";
            int klucz = 3;
            String oczekiwanyWynik = "def";
            String rzeczywistyWynik = cezar.Szyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwanyWynik, rzeczywistyWynik);
            
        }

        [TestMethod]
        public void TestMethod2() 
        {
            Cezar cezar = new Cezar();
            string tekstJawny = "xyz";
            int klucz = 3;
            String oczekiwanyWynik = "abc";
            String rzeczywistyWynik = cezar.Szyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwanyWynik, rzeczywistyWynik);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Cezar cezar = new Cezar();
            string tekstJawny = "def";
            int klucz = -3;
            String oczekiwanyWynik = "abc";
            String rzeczywistyWynik = cezar.Szyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwanyWynik, rzeczywistyWynik);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Cezar cezar = new Cezar();
            string tekstJawny = "abc";
            int klucz = 29;
            String oczekiwanyWynik = "def";
            String rzeczywistyWynik = cezar.Szyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwanyWynik, rzeczywistyWynik);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Cezar cezar = new Cezar();
            string tekstJawny = "ab cd";
            int klucz = 2;
            String oczekiwanyWynik = "cd ef";
            String rzeczywistyWynik = cezar.Szyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwanyWynik, rzeczywistyWynik);
        }
    }
}
