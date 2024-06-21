using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheFoodRecipe.Models.DetailsPageViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentView
    {
        public DetailPage()
        {
            InitializeComponent();
        }
    }
}