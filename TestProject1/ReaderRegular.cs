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
    public class ReaderRegularUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var bob = CreateTestReaderRegular();

            Assert.AreEqual("Боб", bob.Name);
            Assert.AreEqual("Харингтон", bob.Surname);
            Assert.AreEqual(342233, bob.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var bob = CreateTestReaderRegular();
            Assert.AreEqual("Боб Харнгтон", bob.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var bob = CreateTestReaderRegular();
            bob.Literature = new List<string> { "Гёте. Фауст", "Джордж Мартин. Игра престолов" };
            bob.StartDate = new DateTime(2012, 7, 10);
            bob.Span = new TimeSpan(7, 0, 0, 0);
            bob.Pawn = 1000;

            var info = bob.GetInfo();
            Assert.AreEqual(info[0], "Боб Харингтон (342233)");
            Assert.AreEqual(info[1], "Список взятой литературы:\n\tГёте. Фауст\n\tДжордж Мартин. Игра престоловФрэнк");
            Assert.AreEqual(info[2], "Дата выдачи: 10.07.2012. Срок выдачи: 7 дней. Предполагаемая дата возврата: 17.07.2012. Сумма залога: 1000 фунтов");
            Assert.AreEqual(info[3], "Постоянный читатель. Дата записи: 29.04.2009. Адрес: загородный дом. Номер телефона: 865684.");
        }

        private Reader CreateTestReaderRegular()
        {
            return new ReaderRegular("Боб", "Харингтон", 342233, new DateTime(2009, 4, 29), "загородный дом", 865684);
        }
    }

}
