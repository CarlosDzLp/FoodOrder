using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using FoodOrder.Models;
using FoodOrder.ViewModels.Base;
using Xamarin.Forms;

namespace FoodOrder.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        #region Properties
        public ObservableCollection<FoodModel> ListMenu { get; set; }
        public ObservableCollection<string> ListMenuLateral { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int Count { get; set; } = 0;
        #endregion

        #region Constructor
        public MainPageViewModel()
        {
            ListMenu = new ObservableCollection<FoodModel>();
            ListMenuLateral = new ObservableCollection<string>
            {
                "https://mk0madklubben208sy3o.kinstacdn.com/wp-content/uploads/2020/07/restaurant_hero_FCKbh.jpg",               
                "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/nourish_site_front_other/%201800x1200_raw_foods_diet_other.jpg",
                "https://rs.projects-abroad.net/v1/hero/indian-cuisine-south-africa-food-tours-product-5e146c7a97eb2.[1600].jpeg"
            };
        }
        #endregion

        #region CommandExecuted
        public void AddCartCommandExecuted(FoodModel food)
        {
            try
            {
                if (food == null)
                    return;
                Count += 1;
            }
            catch(Exception ex)
            {

            }
        }
        public void SelectedTabViewCommandExecuted(int index)
        {
            try
            {
                ListMenu.Clear();
                if (index == 0)
                {
                    //breakfast
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://upload.wikimedia.org/wikipedia/commons/f/f7/Eggs%2C_parmesan_and_carrots_with_cream.jpeg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Egg Toast",
                        Price = "$30"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://upload.wikimedia.org/wikipedia/commons/f/f7/Eggs%2C_parmesan_and_carrots_with_cream.jpeg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Egg Toast",
                        Price = "$30"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://upload.wikimedia.org/wikipedia/commons/f/f7/Eggs%2C_parmesan_and_carrots_with_cream.jpeg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Egg Toast",
                        Price = "$30"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://upload.wikimedia.org/wikipedia/commons/f/f7/Eggs%2C_parmesan_and_carrots_with_cream.jpeg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Egg Toast",
                        Price = "$30"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://upload.wikimedia.org/wikipedia/commons/f/f7/Eggs%2C_parmesan_and_carrots_with_cream.jpeg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Egg Toast",
                        Price = "$30"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://upload.wikimedia.org/wikipedia/commons/f/f7/Eggs%2C_parmesan_and_carrots_with_cream.jpeg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Egg Toast",
                        Price = "$30"
                    });
                }
                else if(index == 1)
                {
                    //sandwiches
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.ciafoodies.com/wp-content/uploads/2019/10/PM_20161005_AP_11-1024x767.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Sandwiches",
                        Price = "$50"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.ciafoodies.com/wp-content/uploads/2019/10/PM_20161005_AP_11-1024x767.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Sandwiches",
                        Price = "$50"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.ciafoodies.com/wp-content/uploads/2019/10/PM_20161005_AP_11-1024x767.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Sandwiches",
                        Price = "$50"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.ciafoodies.com/wp-content/uploads/2019/10/PM_20161005_AP_11-1024x767.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Sandwiches",
                        Price = "$50"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.ciafoodies.com/wp-content/uploads/2019/10/PM_20161005_AP_11-1024x767.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Sandwiches",
                        Price = "$50"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.ciafoodies.com/wp-content/uploads/2019/10/PM_20161005_AP_11-1024x767.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Sandwiches",
                        Price = "$50"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.ciafoodies.com/wp-content/uploads/2019/10/PM_20161005_AP_11-1024x767.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Sandwiches",
                        Price = "$50"
                    });

                }
                else if(index == 2)
                {
                    //salads
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.budgetbytes.com/wp-content/uploads/2018/07/Build-Cobb-Salads-Step-3.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Salads",
                        Price = "$70"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.budgetbytes.com/wp-content/uploads/2018/07/Build-Cobb-Salads-Step-3.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Salads",
                        Price = "$70"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.budgetbytes.com/wp-content/uploads/2018/07/Build-Cobb-Salads-Step-3.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Salads",
                        Price = "$70"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.budgetbytes.com/wp-content/uploads/2018/07/Build-Cobb-Salads-Step-3.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Salads",
                        Price = "$70"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.budgetbytes.com/wp-content/uploads/2018/07/Build-Cobb-Salads-Step-3.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Salads",
                        Price = "$70"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.budgetbytes.com/wp-content/uploads/2018/07/Build-Cobb-Salads-Step-3.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Salads",
                        Price = "$70"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.budgetbytes.com/wp-content/uploads/2018/07/Build-Cobb-Salads-Step-3.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Salads",
                        Price = "$70"
                    });
                    ListMenu.Add(new FoodModel
                    {
                        Url = "https://www.budgetbytes.com/wp-content/uploads/2018/07/Build-Cobb-Salads-Step-3.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        Name = "Salads",
                        Price = "$70"
                    });
                }
            }
            catch(Exception ex)
            {

            }
        }
        #endregion
    }
}
