using System;
namespace BluetoothApplication.ViewModels
{
    public class UITestViewModel : BaseViewModel
    {
        public UITestViewModel()
        {
            Title = "UITest";
        }

        private string _text1;
        private string Text1
        {
            get
            {
                return _text1;
            }
            set
            {
                _text1 = value;
                OnPropertyChanged(nameof(Text1));
            }
        }
    }
}
