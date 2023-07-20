using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TableCollege.ViewModel;
namespace UnitTestHashCode
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHashCode_Convert_String_ToMD5_Hello_5d41402abc4b2a76b9719d911017c592()
        {
                string hash = HashCode.GetHashCode("hello");
                Assert.AreEqual(hash.ToLower(), "5d41402abc4b2a76b9719d911017c592");
        }
    }
}
