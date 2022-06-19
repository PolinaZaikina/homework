using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library12;
using NUnit.Framework;


namespace Library12.Test
{
    [TestFixture]
    public class VisitorUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var sam = CreateTestVisitor();

            Assert.AreEqual("Сэм", sam.Name);
            Assert.AreEqual("Финк", sam.Surname);
            Assert.AreEqual(0, sam.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var sam = CreateTestVisitor();
            Assert.AreEqual("Сэм Финк", sam.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var sam = CreateTestVisitor();
            sam.Literature = new List<string> { "Он зашел по ошибке" };
            sam.StartDate = new DateTime(2012, 5, 18);
            sam.Span = new TimeSpan(0, 0, 0, 0);
            sam.Pawn = 0;

            var info = sam.GetInfo();
            Assert.AreEqual(info[0], "Сэм Финк (0)");
            Assert.AreEqual(info[1], "Список взятой литературы:\n\tОн зашел по ошибке");
            Assert.AreEqual(info[2], "Дата выдачи: 18.05.2012. Срок выдачи: 0 дней.  Сумма залога: 0 фунтов");
            Assert.AreEqual(info[3], "Посетитель. Время посещения: 14:00 - 14:15. Паспорт: 2662896189");
        }

        private Reader CreateTestVisitor()
        {
            return new Visitor("Сэм", "Финк", 0, new DateTime(2012, 5, 18, 14, 0, 0), new DateTime(2012, 5, 18, 14, 15, 0), "Паспорт", 2662896189);
        }
    }

}
