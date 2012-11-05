﻿using Client.Common.Results;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Client.Common.Tests
{
    [TestClass]
    public class SubsonicServiceTests
    {
        private SubsonicService _subject;

        [TestInitialize]
        public void Setup()
        {
            _subject = new SubsonicService();
        }

        [TestMethod]
        public void GetRootIndex_Always_ReturnsAGetIndexResult()
        {
            var result = _subject.GetRootIndex();

            Assert.IsInstanceOfType(result, typeof(GetIndexResult));
        }
    }
}