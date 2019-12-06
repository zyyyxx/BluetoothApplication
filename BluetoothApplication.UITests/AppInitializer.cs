using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace BluetoothApplication.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    //.ApkFile("")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .InstalledApp("../../BluetoothApplication.iOS/bin/iPhoneSimulator/Debug/device-builds/iphone12.3-13.2/BluetoothApplication.iOS.app")
                .StartApp();
        }
    }
}