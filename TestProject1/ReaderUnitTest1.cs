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

            Assert.AreEqual("�����", peter.Name);
            Assert.AreEqual("�����", peter.Surname);
            Assert.AreEqual(356895, peter.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var peter = CreateTestReader();
            Assert.AreEqual("����� �����", peter.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var peter = CreateTestReader();
            peter.Literature = new List<string> { "����� �����. �������� ���������" };
            peter.StartDate = new DateTime(2012, 1, 4);
            peter.Span = new TimeSpan(7, 0, 0, 0);
            peter.Pawn = 1000;

            var info = peter.GetInfo();
            Assert.AreEqual(info[0], "����� ����� (356895)");
            Assert.AreEqual(info[1], "������ ������ ����������:\n\t����� �����. �������� ���������");
            Assert.AreEqual(info[2], "���� ������: 04.01.2012. ���� ������: 7 ����. �������������� ���� ��������: 11.01.2012. ����� ������: 1000 ������");
        }

        private Reader CreateTestReader()
        {
            return new Reader("�����", "�����", 356895);
        }
    }

}