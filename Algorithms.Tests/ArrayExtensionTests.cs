using NUnit.Framework;
using Algorithms;
using static Algorithms.ArrayExtension;
namespace Algorithms.Tests
{
    [TestFixture]
    public class ArrayExtensionTests
    {
        [Test]
        public void Binary_Test_1()
        {
            int[] a = { 5, 3, 7, 2, 1, 1 };
            a.BubbleSort(new PBinarySystem(), new BinaryIndex());
            CollectionAssert.AreEqual(new[] { 7, 3, 5, 2, 1, 1 }, a);
        }
        [Test]
        public void Hex_Test_1()
        {
            int[] a = { 0, 0, 10 };
            a.BubbleSort(new PHexSystem(), new BinaryIndex());
            CollectionAssert.AreEqual(new[] { 10, 0, 0 }, a);
        }
        [Test]
        public void Binary_Test_2()
        {
            int[] a = { 5, 3, 7, 2, 1, 1 };
            a.BubbleSort(new PBinarySystem(), new BoundaryIndex(1,3));
            CollectionAssert.AreEqual(new[] { 5, 7, 3, 2, 1, 1 }, a);
        }
    }
}
