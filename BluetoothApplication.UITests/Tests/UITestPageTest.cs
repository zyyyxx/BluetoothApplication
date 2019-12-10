using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace BluetoothApplication.UITests.Tests
{
    public class UITestPageTest : BaseTest
    {
        public UITestPageTest(Platform platform) : base(platform)
        {
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void EntryTextName()
        {
            app.Query(c => c.Marked("temp1"));

            //app.Repl();
        }

        [Test]
        public void Repl()
        {
            app.Repl();
        }
    }
}
