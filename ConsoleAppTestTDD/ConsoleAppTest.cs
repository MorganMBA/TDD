using NUnit.Framework;
using System.Collections.Generic;

namespace ConsoleAppTestTDD
{
    [TestFixture]
    public class ConsoleAppTest
    {
        [Test]
        public void ReadListTest()
        {
            ConsoleApp consoleApp = new ConsoleApp();
            var list = new List<string> { "+ ajouter", "+ ranger" };
            var assert = consoleApp.ReadList(list);
        }
    }
}
