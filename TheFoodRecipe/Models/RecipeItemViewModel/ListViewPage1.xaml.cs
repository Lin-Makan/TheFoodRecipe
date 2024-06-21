using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TheMealDB.API.Client;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheFoodRecipe.Models.RecipeItemViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListViewPage1()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {

       
        {
             "Baked salmon with fennel & tomatoes",
             "https://www.themealdb.com/images/media/meals/1548772327.jpg",
              private const string v = "52959";
              public ObservableCollection<string> Items { set; get; },
        {
               "Cajun spiced fish tacos",
               "https://www.themealdb.com/images/media/meals/uvuyxu1503067369.jpg",
               "52819"
        },
        {
             "Escovitch Fish",
             "https://www.themealdb.com/images/media/meals/1520084413.jpg",
                
             "52944";
        },
        {
            "strMeal": "Fish fofos",
            "strMealThumb": "https://www.themealdb.com/images/media/meals/a15wsa1614349126.jpg",
            "idMeal": "53043"
        },
        {
            "Fish pie",
            "https://www.themealdb.com/images/media/meals/ysxwuq1487323065.jpg",
            "52802"
        },
        {
            "strMeal": "Fish Soup (Ukha)",
            "strMealThumb": "https://www.themealdb.com/images/media/meals/7n8su21699013057.jpg",
            "idMeal": "53079"
        },
        {
            "Fish Stew with Rouille",
            "https://www.themealdb.com/images/media/meals/vptqpw1511798500.jpg",
            "52918"
        },
        {
             "Garides Saganaki",
             "https://www.themealdb.com/images/media/meals/wuvryu1468232995.jpg",
             "52764"
        },
        {
             "Grilled Portuguese sardines",
             "https://www.themealdb.com/images/media/meals/lpd4wy1614347943.jpg",
             "53041"
        },
        {
            "Honey Teriyaki Salmon",
            "https://www.themealdb.com/images/media/meals/xxyupu1468262513.jpg",
            "52773"
        },
        {
            "Kedgeree",
            "https://www.themealdb.com/images/media/meals/utxqpt1511639216.jpg",
            "52887"
        },
        {
            "Kung Po Prawns",
            "https://www.themealdb.com/images/media/meals/1525873040.jpg",
            "52946"
        },
        {
            "Laksa King Prawn Noodles",
            "https://www.themealdb.com/images/media/meals/rvypwy1503069308.jpg",
            "52821"
        },
        {
            "Mediterranean Pasta Salad",
            "https://www.themealdb.com/images/media/meals/wvqpwt1468339226.jpg",
            "52777"
        },
        {
            "Mee goreng mamak",
            "https://www.themealdb.com/images/media/meals/xquakq1619787532.jpg",
            "53048"
        },
        {
            "Nasi lemak",
            "https://www.themealdb.com/images/media/meals/wai9bw1619788844.jpg",
             "53051"
        },
        {
             "Caldeirada de peixe)",
             "https://www.themealdb.com/images/media/meals/do7zps1614349775.jpg",
             "53045"
        },
        {
            "Recheado Masala Fish",
            "https://www.themealdb.com/images/media/meals/uwxusv1487344500.jpg",
            "52809"
        },
        {
            "Salmon Avocado Salad",
            "https://www.themealdb.com/images/media/meals/1549542994.jpg",
            "52960"
        },
        {
            "Salmon Prawn Risotto",
            "https://www.themealdb.com/images/media/meals/xxrxux1503070723.jpg",
            "52823"
        },
        {
            "Saltfish and Ackee",
            "https://www.themealdb.com/images/media/meals/vytypy1511883765.jpg",
            "52936"
        },
        {
            "Seafood fideuà",
            "https://www.themealdb.com/images/media/meals/wqqvyq1511179730.jpg",
            "52836"
        },
        {
            "Shrimp Chow Fun",
            "https://www.themealdb.com/images/media/meals/1529445434.jpg",
            "52953"
        },
        {
            "Sledz w Oleju (Polish Herrings)",
            "https://www.themealdb.com/images/media/meals/7ttta31593350374.jpg",
            "53023"
        },
        {
            "Spring onion and prawn empanadas",
            "https://www.themealdb.com/images/media/meals/1c5oso1614347493.jpg",
           "53040"
        },
        {
            "Sushi",
            "https://www.themealdb.com/images/media/meals/g046bb1663960946.jpg",
            "53065"
        },
        {
            "Three Fish Pie",
            "https://www.themealdb.com/images/media/meals/spswqs1511558697.jpg",
            "52882"
        },
        {
            "Tuna and Egg Briks",
            "https://www.themealdb.com/images/media/meals/2dsltq1560461468.jpg",
            "52975"
        },
        {
            "Tuna Nicoise",
            "https://www.themealdb.com/images/media/meals/yypwwq1511304979.jpg",
            "52852"
        }
    
}
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
