using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BluetoothApplication.Views
{
    public partial class BluetoothPage : ContentPage
    {
        public BluetoothPage()
        {
            InitializeComponent();
        }

        public async void ConnectToBluetoothDevice(object sender, EventArgs args)
        {
            await Label.RelRotateTo(360, 1000);
        }
    }
}
