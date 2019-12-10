using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace BluetoothApplication.UITests.Tests
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class BluetoothPageUITest
    {
        IApp _app;
        Platform _platform;

        public BluetoothPageUITest(Platform platform)
        {
            _platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(_platform);
        }

        [Test]
        public void LabelsAreCorrect()
        {
            _app.Query(c => c.Marked("Label1"));
        }

    }
}
