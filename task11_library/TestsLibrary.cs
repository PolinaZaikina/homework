using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task11_library;

namespace task11_library.Tests
{
    public class ReaderUnitTests
    {

        public void ConstructorTest()
        {
            var violetta = CreateTestReader();

            Assert.AreEqual("Виолетта", violetta.Name);
            Assert.AreEqual("Осипова", violetta.Surname);
            Assert.AreEqual(568923, violetta.Number);
        }


        public void TimeTest()
        {
            var violetta = CreateTestReader();

            violetta.StartDate = new DateTime(2017, 2, 5);
            violetta.Span = new TimeSpan(9, 0, 0, 0);

            Assert.AreEqual(violetta.EndDate, new DateTime(2017, 2, 21));
        }


        public void ToStringTest()
        {
            var violetta = CreateTestReader();
            Assert.AreEqual("Виолетта Осипова", violetta.ToString());
        }

        private Reader CreateTestReader()
        {
            return new Reader("Виолетта", "Осипова", 568923);
        }

    }
}
