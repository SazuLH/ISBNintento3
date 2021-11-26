using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestISBN3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodISBN10Valid()
        {
            int ISBN10 = 0;
            bool ISBNvalid = false;
            int[] digit = {0, 7, 1, 6, 7, 0, 3, 4, 4, 0};

            ISBN10 = ((digit[0] *10) + (digit[1] *9) + (digit[2] *8) + (digit[3] *7) + (digit[4] *6) + (digit[5] *5) + (digit[6] *4) + (digit[7] *3) + (digit[8] *2) + (digit[9] *1));
            ISBNvalid = (ISBN10 % 11 == 0);

            if (ISBN10 == 0)
            {
                Assert.IsTrue(ISBNvalid);
            }
        }
        [TestMethod]
        public void TestMethodISBN10Invalid()
        {
            int ISBN10 = 0;
            bool ISBNinvalid = false;
            int[] digit = {1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };

            ISBN10 = ((digit[0] * 10) + (digit[1] * 9) + (digit[2] * 8) + (digit[3] * 7) + (digit[4] * 6) + (digit[5] * 5) + (digit[6] * 4) + (digit[7] * 3) + (digit[8] * 2) + (digit[9] * 1));
            ISBNinvalid = (ISBN10 % 11 == 0);

            if (ISBN10 != 0)
            {
                Assert.IsFalse(ISBNinvalid);
            }
        }

        [TestMethod]
        public void TestMethodISBN13Valid()
        {
            int ISBN13 = 0;
            bool ISBNvalid13 = false;
            int[] digit = { 9, 7, 8, 0, 7, 1, 6, 7, 0, 3, 4, 4, 0 };

            ISBN13 = ((digit[0] * 1) + (digit[1] * 3) + (digit[2] * 1) + (digit[3] * 3) + (digit[4] * 1) + (digit[5] * 3) + (digit[6] * 1) + (digit[7] * 3) + (digit[8] * 1) + (digit[9] * 3) + (digit[10] * 1) + (digit[11] * 3) + (digit[12] * 1));
            ISBNvalid13 = (ISBN13 % 10 == 0);

            if (ISBN13 == 0)
            {
                Assert.IsTrue(ISBNvalid13);
            }
        }
        [TestMethod]
        public void TestMethodISBN13Invalid()
        {
            int ISBN13 = 0;
            bool ISBNvalid13 = false;
            int[] digit = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 0 };

            ISBN13 = ((digit[0] * 1) + (digit[1] * 3) + (digit[2] * 1) + (digit[3] * 3) + (digit[4] * 1) + (digit[5] * 3) + (digit[6] * 1) + (digit[7] * 3) + (digit[8] * 1) + (digit[9] * 3) + (digit[10] * 1) + (digit[11] * 3) + (digit[12] * 1));
            ISBNvalid13 = (ISBN13 % 10 == 0);

            if (ISBN13 != 0)
            {
                Assert.IsFalse(ISBNvalid13);
            }
        }
    }
}
