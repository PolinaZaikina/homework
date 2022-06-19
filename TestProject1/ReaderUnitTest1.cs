using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library12;


namespace Library12.Test
{
    [TestFixture]
    public class ReaderUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var peter = CreateTestReader();

            Assert.AreEqual("Питер", peter.Name);
            Assert.AreEqual("Джонс", peter.Surname);
            Assert.AreEqual(356895, peter.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var peter = CreateTestReader();
            Assert.AreEqual("Питер Джонс", peter.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var peter = CreateTestReader();
            peter.Literature = new List<string> { "Морис Дрюон. Собрание сочинений" };
            peter.StartDate = new DateTime(2012, 1, 4);
            peter.Span = new TimeSpan(7, 0, 0, 0);
            peter.Pawn = 1000;

            var info = peter.GetInfo();
            Assert.AreEqual(info[0], "Питер Джонс (356895)");
            Assert.AreEqual(info[1], "Список взятой литературы:\n\tМорис Дрюон. Собрание сочинений");
            Assert.AreEqual(info[2], "Дата выдачи: 04.01.2012. Срок выдачи: 7 дней. Предполагаемая дата возврата: 11.01.2012. Сумма залога: 1000 фунтов");
        }

        private Reader CreateTestReader()
        {
            return new Reader("Питер", "Джонс", 356895);
        }
    }

}