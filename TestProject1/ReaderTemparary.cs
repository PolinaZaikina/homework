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
    public class ReaderTemporaryUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var bill = CreateTestReaderTemporary();

            Assert.AreEqual("Билл", bill.Name);
            Assert.AreEqual("Шифер", bill.Surname);
            Assert.AreEqual(352435, bill.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var bill = CreateTestReaderTemporary();
            Assert.AreEqual("Билл Шифер", bill.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var bill = CreateTestReaderTemporary();
            bill.Literature = new List<string> { "Гоголь.Ревизор" };
            bill.StartDate = new DateTime(2012, 2, 7);
            bill.Span = new TimeSpan(7, 0, 0, 0);
            bill.Pawn = 1000;

            var info = bill.GetInfo();
            Assert.AreEqual(info[0], "Билл Шифер (352435)");
            Assert.AreEqual(info[1], "Список взятой литературы:\n\tГоголь.Ревизор");
            Assert.AreEqual(info[2], "Дата выдачи: 07.02.2012. Срок выдачи: 7 дней. Предполагаемая дата возврата: 14.02.2012. Сумма залога: 1000 фунтов");
            Assert.AreEqual(info[3], "Временный читатель. Дата окончания допуска: 01.01.2013. Доступные отделы:\n\tКниги на шрифте Брайля\n\tАудиокниги");
        }

        private Reader CreateTestReaderTemporary()
        {
            return new ReaderTemparary("Билл", "Шифер", 352435, new DateTime(2013, 1, 1), new List<string> { "Книги на шрифте Брайля", "Аудиокниги" });
        }
    }

}
