using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DesiTadkaRestaurant.Models;


namespace DesiTadkaRestaurant.Models
{
    public class Details : DropCreateDatabaseAlways<DesiTadka>
    {
        protected override void Seed(DesiTadka context)
        {
            var types = new List<MenuType>
            {
                new MenuType { Name = "Appetizer"},
                new MenuType { Name = "Main Course"},
                new MenuType { Name = "Desserts"}
            };

            new List<MenuItem>
            {
                new MenuItem {MenuName = "Rasgulla",description="Rasgulla is a syrupy dessert popular in the Indian subcontinent and regions with South Asian diaspora. It is made from ball shaped dumplings of chhena and semolina dough, cooked in light syrup made of sugar", Price=10M, MenuType = types.Single(g => g.Name == "Dessert"), FoodUrl = "/Assets/Images/Desserts/3.jpg" },
                new MenuItem {MenuName = "Malai kofta", description="malai means cream and kofta are fried dumpling balls. usually they are made up of mashed potatoes-veggies, with or without grated paneer. other kofta gravy recipes on the blog are cabbage kofta curry and lauki kofta recipe.", Price=10.25M, MenuType = types.Single(g => g.Name == "Main Course"), FoodUrl = "/Assets/Images/MainCourses/1-2.jpg" },
                new MenuItem {MenuName = "Kadai Mashroom Gravy", description = "It is one of the popular punjabi recipes. here i am sharing the gravy version with mushrooms. i have used white button mushrooms, but you can use any variety of edible mushrooms. if you are looking for a semi dry version of kadai mushroom, then you can check this recipe – kadai mushroom dry", Price=12.25M, MenuType= types.Single(g => g.Name == "Main Course"), FoodUrl = "/Assets/Images/MainCourses/3.jpg" },
                new MenuItem {MenuName = "Chaat: Dahi Batata Puri", description="Chaat is a broad term that encompasses many different dishes. This recipe is made of yogurt and potatoes and other chaat sauces. You may need to make a trip to an Indian grocery store to stock up on spherical 'puris' (also called as pani-puri puris), 'sev', green chutney, and a sweet and sour chutney. I have tried here to give as many substitutions as possible, if you are unable to go to an Indian grocery store", Price=8.99M, MenuType= types.Single(g => g.Name == "Appetizer"), FoodUrl="/Assets/Images/Appetizers/2.jpg" },
                new MenuItem {MenuName = "Crispy Aloo Pakoras", description="Crispy aloo pakoras are a flavorful and delicious snack specially when it is served with cilantro chutney, and hot cup of chai. They are easy and quick to make. Welcome your surprise guest and treat them with these mouthwatering crispy aloo pakoras", Price=12.75M, MenuType= types.Single(g => g.Name == "Appetizer"), FoodUrl="/Assets/Images/Appetizers/4.jpg" }


            }.ForEach(a => context.MenuItems.Add(a));
        }
    }
}