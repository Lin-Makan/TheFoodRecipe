using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MealDB.API.Client;
using Xamarin.Forms;

namespace TheFoodRecipe.Models.RecipeItemViewModel
{
    public class MealPrep : ContentView
    {
        public MealPrep()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Meal Prep Instructions:" }
                }
            };
        }
    }
}