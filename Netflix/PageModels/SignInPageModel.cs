using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Netflix.PageModels
{
    public class SignInPageModel : PageModelBase
    {
        public SignInPageModel()
        {
            IsPassword = true;
            IsPasswordCommand = new Command(() =>
            {
                IsPassword = !IsPassword;
            });
        }

        private bool _isPassword;
        public bool IsPassword
        {
            get { return _isPassword; }
            set => SetProperty(ref _isPassword, value);
        }

        public ICommand IsPasswordCommand { get; }
    }
}
