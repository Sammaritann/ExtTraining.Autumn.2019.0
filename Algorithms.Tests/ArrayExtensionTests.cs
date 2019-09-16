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
            int[] a = { 5, 3, 7, 2,1,1 };
           
            CollectionAssert.AreEqual(new[] { 7,3,5,2,1,1},a.BubbleSort(new PBinarySystem(),new BinaryIndex()));
        }
    }
}
