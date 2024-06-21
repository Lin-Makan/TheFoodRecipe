using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms.PancakeView;
using Xamarin.FFImageLoading.Forms;
using TheMealDB.API.Client;
using Xamarin.Forms;

namespace TheFoodRecipe.Models.CatergoriesViewModel
{
    public class Catergories : ContentPage
    {
        public Catergories()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Choose Your Recipe" }
                }
            };
        }
    }
}