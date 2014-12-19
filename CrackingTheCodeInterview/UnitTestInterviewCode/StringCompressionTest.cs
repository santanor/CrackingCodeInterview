using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCompression;

namespace UnitTestInterviewCode
{
    [TestClass]
    public class StringCompressionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringCompressor sc = new StringCompressor();

            Assert.AreEqual<string>("2a1b5c3b", sc.Compress("aabcccccbbb"));
            Assert.AreEqual<string>("aa", sc.Compress("aa"));
            Assert.AreEqual<string>("", sc.Compress(""));
            Assert.AreEqual<string>("", sc.Compress(null));
            Assert.AreEqual<string>("abccdefg", sc.Compress("abccdefg"));
            Assert.AreEqual<string>("3a3b1g1c3t3s2f", sc.Compress("aaabbbgctttsssff"));
        }
    }
}
