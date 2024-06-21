using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using TheMealDB.API.Client;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TheFoodRecipe.Models.LoginViewModel
{
    public class BaseView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
