using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("200 -20", Kata.HighAndLow("100 -2 10 5 -20 -3 200 150 5"));
        }
        [Test]
        [TestCase(155, ExpectedResult = -1)]
        [TestCase(121, ExpectedResult = 144)]
        [TestCase(625, ExpectedResult = 676)]
        [TestCase(319225, ExpectedResult = 320356)]
        [TestCase(15241383936, ExpectedResult = 15241630849)]
        public static long FixedTest(long num)
        {
            return Kata.FindNextSquare(num);
        }
    }
    //[TestFixture]
    /*public class JadenCaseTest
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                            "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                            "Strings didn't match.");
        }
    }*/
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Kata.AlphabetPosition("The narwhal bacons at midnight."));
        }
    }
    [TestFixture]
    public class DuplicateCountTest
    {
        [Test]
        [TestCase("abcd", ExpectedResult = 0)]
        [TestCase("aab123", ExpectedResult = 1)]
        [TestCase("ab1233", ExpectedResult = 1)]
        [TestCase("aabB123", ExpectedResult = 2)]
        [TestCase("aabB1223", ExpectedResult = 3)]
        [TestCase("aabBb12223", ExpectedResult = 3)]

        public static int DuplicateTest(String input)
        {
            return Kata.DuplicateCount(input);
        }
    }

    [TestFixture]
    public class DescendingOrderTest
    {
        [Test]
        [TestCase(12345, ExpectedResult = 54321)]
        [TestCase(251, ExpectedResult = 521)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(21, ExpectedResult = 21)]
        [TestCase(9875517, ExpectedResult = 9877551)]
        public static int DescendingTest(int num)
        {
            return Kata.DescendingOrder(num);
        }
       
    }
    [TestFixture]
    public class ComplimentTest
    {
        [Test]
        public void ComplimentTest1()
        {
            Assert.AreEqual("TGAC", Kata.MakeComplement("ACTG"));
        }
    }
    [TestFixture]
    public class FriendOrFoeTest
    {
        [Test]
        public void FriendOrFoeTest1()
        {
            string[] input = { "blahblah", "Josh", "eyyoooot", "Yeet", "no" };
            string[] expected = { "Josh", "Yeet" };

            Assert.AreEqual(expected, Kata.FriendOrFoe(input));
        }
        [Test]
        public void FriendOrFoeTest2()
        {
            string[] input = {"nothing"};
            string[] expected = {};

            Assert.AreEqual(expected, Kata.FriendOrFoe(input));
        }
        [Test]
        public void FriendOrFoeTest3()
        {
            string[] input = {};
            string[] expected = {};

            Assert.AreEqual(expected, Kata.FriendOrFoe(input));
        }
    }
    [TestFixture]

    public class AccumTest
    {
        [Test]
        [TestCase("abc", ExpectedResult = "A-Bb-Ccc")]
        [TestCase("a", ExpectedResult = "A")]
        [TestCase("abc", ExpectedResult = "A-Bb-Ccc")]

        public string AccumTester(string input)
        {
            return Kata.Accum(input);
        }

    }

    [TestFixture]
    public class BinaryAddTest
    {
        [Test]
        public void BinaryAddTest1()
        {
            Assert.AreEqual("11", Kata.AddBinary(1, 2));
        }
        //[TestCase(1, 2, ExpectedResult = "11")]
    }
    [TestFixture]
    public class DigPowTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, Kata.digPow(89, 1));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, Kata.digPow(92, 1));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(51, Kata.digPow(46288, 3));
        }
    }
    [TestFixture]
    public class ReverseWordsTest
    {
        [Test]
        [TestCase("Hello World!", ExpectedResult = "olleH !dlroW")]

        public static string ReverseWordsTester(string str)
        {
            return Kata.ReverseWords(str);
        }
    }

    [TestFixture]
    public class IsPanagramTest
    {
        [Test]
        public void trueTest()
        {
            Assert.AreEqual(true, Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
        [Test]
        public void falseTest()
        {
            Assert.AreEqual(false, Kata.IsPangram("The uick brown fox jumps over the lazy dog."));
        }
    }
    [TestFixture]
    public class DeleteNthTest
    {
        [Test]
        public void testOne()
        {
            var expected = new int[]{ 1, 2, 3 };

            Assert.AreEqual(expected, Kata.DeleteNth(new int[] { 1, 2, 3 }, 2));
        }
        [Test]
        public void test2()
        {
            var expected = new int[] { 1, 2, 3 };

            Assert.AreEqual(expected, Kata.DeleteNth(new int[] { 1, 1, 2, 3, 3 }, 1));
        }
        [Test]
        public void test3()
        {
            var expected = new int[] { 1 };

            Assert.AreEqual(expected, Kata.DeleteNth(new int[] { 1 }, 1));
        }
        [Test]
        public void test4()
        {
            var expected = new int[] {};

            Assert.AreEqual(expected, Kata.DeleteNth(new int[] {1, 1}, 0));
        }
    }
    [TestFixture]
    public class sumLowestPossibleNumbersTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 3)]
        [TestCase(new int[] {25, 1, 7, 6 }, ExpectedResult = 7)]
        [TestCase(new int[] { 8, 0, 12, 11, 100 }, ExpectedResult = 8)]

        public int sumLowestTester(int[] arr)
        {
            return Kata.sumTwoSmallestNumbers(arr);
        }

    }
    [TestFixture]
    public class StockListTests
    {
        [Test]
        public void Test1()
        {
            string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
            String[] cd = new String[] { "A", "B" };
            Assert.AreEqual("(A : 200) - (B : 1140)", Kata.StockList.stockSummary(art, cd));
        }
        [Test]
        public void Test2()
        {
            string[] art = new string[] {};
            String[] cd = new String[] { "A", "B" };
            Assert.AreEqual("", Kata.StockList.stockSummary(art, cd));
        }
        [Test]
        public void Test3()
        {
            string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
            String[] cd = new String[] {};
            Assert.AreEqual("", Kata.StockList.stockSummary(art, cd));
        }
        [Test]
        public void Test4()
        {
            string[] art = new string[] { };
            String[] cd = new String[] { };
            Assert.AreEqual("", Kata.StockList.stockSummary(art, cd));
        }
    }
    [TestFixture]
    public class DecomposeTests
    {
        [Test]
        public void Test1()
        {
            Kata.Decompose d = new Kata.Decompose();
            long n = 11;
            Assert.AreEqual("1 2 4 10", d.decompose(n));
        }
    }
    public class averageTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(", ", new double[] { 2, 2, 2, 2 }), string.Join(", ", Kata.Averages(new int[] { 2, 2, 2, 2, 2 })));
            Assert.AreEqual(string.Join(", ", new double[] { 0, 0, 0, 0 }), string.Join(", ", Kata.Averages(new int[] { 2, -2, 2, -2, 2 })));
            Assert.AreEqual(string.Join(", ", new double[] { 2, 4, 3, -4.5 }), string.Join(", ", Kata.Averages(new int[] { 1, 3, 5, 1, -10 })));
        }
    }

}
