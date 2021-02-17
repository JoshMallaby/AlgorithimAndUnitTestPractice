using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    [TestFixture]
    public class DisemvowelTest
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
        }

    }
}
