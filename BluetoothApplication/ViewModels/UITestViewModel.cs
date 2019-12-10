using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BluetoothApplication.ViewModels
{
    public class UITestViewModel : BaseViewModel
    {
        public UITestViewModel()
        {
            Title = "UITest";

            UpdateResultCommand = new Command(() =>
            {
                SetTemps();
            });
        }

        private void SetTemps()
        {
            Result = Temp;
        }

        protected void OnUITestPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            (UpdateResultCommand as Command).ChangeCanExecute();
        }

        string _temp;
        public string Temp
        {
            get
            {
                return _temp;
            }
            set
            {
                if (_temp == value)
                {
                    return;
                }
                OnPropertyChanged(nameof(Temp));
                SetProperty(ref _temp, value);
            }
        }

        string _result;
        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                if (_result == value)
                {
                    return;
                }
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ICommand UpdateResultCommand { private set; get; }

    }
}
