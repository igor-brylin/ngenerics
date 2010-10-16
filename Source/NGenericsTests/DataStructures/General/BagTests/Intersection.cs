﻿using System;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.BagTests
{
    [TestFixture]
    public class Intersection : BagTest
    {

        [Test]
        public void Simple()
        {
            var bag1 = new Bag<string>();
            var bag2 = GetTestBag();

            var resultBag = bag1 * bag2;

            Assert.IsTrue(resultBag.Equals(bag1));

            bag1.Add("50", 2);

            var shouldBe = new Bag<string>();

            resultBag = bag1 * bag2;

            Assert.IsTrue(shouldBe.Equals(resultBag));

            bag1.Add("2", 2);

            shouldBe.Add("2", 2);

            resultBag = bag1 * bag2;

            Assert.IsTrue(shouldBe.Equals(resultBag));
        }

        [Test]
        public void Interface()
        {
            var bag1 = new Bag<string>();
            var bag2 = GetTestBag();

            var resultBag = (Bag<string>)((IBag<string>)bag1).Intersection(bag2);

            Assert.IsTrue(resultBag.Equals(bag1));

            bag1.Add("50", 2);

            var shouldBe = new Bag<string>();

            resultBag = (Bag<string>)((IBag<string>)bag1).Intersection(bag2);

            Assert.IsTrue(shouldBe.Equals(resultBag));

            bag1.Add("2", 2);

            shouldBe.Add("2", 2);

            resultBag = (Bag<string>)((IBag<string>)bag1).Intersection(bag2);

            Assert.IsTrue(shouldBe.Equals(resultBag));
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionNullb2()
        {
            var bag1 = new Bag<int>();
            var resultBag = bag1 * null;
        }

    }
}