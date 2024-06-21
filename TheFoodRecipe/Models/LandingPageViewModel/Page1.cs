using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheMealDB.API.Client;

using Xamarin.Forms;

namespace TheFoodRecipe.Models.LandingPageViewModel
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Look Out For Your Favourite Recipes" }
                }
            };
        }
    }
}