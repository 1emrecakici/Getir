using Firebase.Database;
using Firebase.Database.Query;
using Getir.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Getir.Helpers
{
    public class AddFoodItemData
    {
        public List<FoodItem> FoodItems { get; set; }
        FirebaseClient client;
        public AddFoodItemData()
        {
            client = new FirebaseClient("https://getir-e16db-default-rtdb.firebaseio.com/");
            FoodItems = new List<FoodItem>()
            {
                new FoodItem()
                {
                    ProductID = 1,
                    CategoryID = 1,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Price = "₺11,99"
                },
                new FoodItem()
                {
                    ProductID = 2,
                    CategoryID = 1,
                    ImageUrl = "http://cdn.getir.com/product/5da3048393cfb89cb5ec6be6_tr_1607784888352.jpeg",
                    Name = "Portakal",
                    Description = "Doğal Portakal",
                    Price = "₺9,95"
                },
                new FoodItem()
                {
                    ProductID = 1,
                    CategoryID = 1,
                    ImageUrl = "http://cdn.getir.com/product/5cac8e6603c5fd0001497b73_1554920279678.jpeg?v=1554920282632",
                    Name = "Elma",
                    Description = "Doğal Elma",
                    Price = "₺7,75"
                },

            };
        }

        public async Task AddFoodItemsAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Description = item.Description,
                        ImageUrl = item.ImageUrl,
                        Price = item.Price
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
