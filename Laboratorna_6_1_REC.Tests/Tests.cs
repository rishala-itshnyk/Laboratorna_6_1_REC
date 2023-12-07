using System;
using Laboratorna_6_1_REC;
using NUnit.Framework;

namespace Laboratorna_6_1_ITER_Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestFillArray()
        {
            int[] b = new int[21];
            Program.FillArray(b);

            for (int i = 0; i < 21; ++i)
            {
                Assert.IsTrue(b[i] >= 10 && b[i] <= 90);
            }
        }   

        [Test]
        public void TestProcessArray()
        {
            int[] b = { 12, 15, 18, 21, 24, 27, 30, 33, 36, 39 };
            int count, sum;

            Program.ProcessArray(b, out count, out sum);

            Assert.AreEqual(5, count);
            Assert.AreEqual(120, sum);

            for (int i = 0; i < b.Length; ++i)
            {
                if (!(b[i] % 2 != 0 && b[i] % 3 == 0))
                {
                    Assert.AreEqual(0, b[i]);
                }
            }
        }
    }
}