﻿using Miam.Web.Automation.Selenium;
using OpenQA.Selenium;

namespace Miam.Web.Automation.PageObjects.RestaurantPages
{
    public class CreateRestaurantPage
    {
        public static void GoTo()
        {
            Navigation.Admin.CreateRestaurant.Select();
        }

        public static CreateRestaurantCommand CreateRestaurant(string restaurantName)
        {
            return new CreateRestaurantCommand(restaurantName);
        }
    }

    public class CreateRestaurantCommand
    {
        private readonly string _restaurantName;
        private string _city;
        private string _country;

        public CreateRestaurantCommand(string restaurantName)
        {
            _restaurantName = restaurantName;
        }

        public CreateRestaurantCommand WithCity(string city)
        {
            _city = city;
            return this;
        }

        public CreateRestaurantCommand WithCountry(string country)
        {
            _country = country;
            return this;
        }

        public void Create()
        {
            Driver.Instance.FindElement(By.Id("Name")).SendKeys(_restaurantName);
            Driver.Instance.FindElement(By.Id("City")).SendKeys(_city);
            Driver.Instance.FindElement(By.Id("Country")).SendKeys(_country);

            Driver.Instance.FindElement(By.Id("create_button")).Click();
        }
    }


}