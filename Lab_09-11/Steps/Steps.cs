﻿using OpenQA.Selenium;

namespace Lab10
{
    public class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = DriverInstance.GetInstance();
            driver.Manage().Window.Maximize();
        }
        public void CloseBrowser()
        {
            DriverInstance.CloseBrowser();
        }

        public void GoToKufarPage()
        {
            KufarPage kufarPage = new KufarPage(driver);
            kufarPage.GoToMainPage();
        }
        public void CloseWarninigAndAdv()
        {
            KufarPage kufarPage = new KufarPage(driver);
            kufarPage.ClosingPolicyAndAdvertisingWindows();
        }
        
        public void LikeAndOpenFavoritePage(User user)
        {
            KufarPage kufarPage = new KufarPage(driver);
            kufarPage.GoToProductPage();
            kufarPage.ClickLikeButton();
            kufarPage.LoginToAccount(user);
            kufarPage.ClickFavorites();
            kufarPage.ClickFavoriteProduct();
        }
        public string GetPageTitle()
        {
            KufarPage page = new KufarPage(driver);
            return page.GetPageTitle();
        }
        public void AddProductToBusketAndOpenProduct()
        {
            KufarMarketPage marketPage = new KufarMarketPage(driver);
            marketPage.ClickAddBusketButton();
            marketPage.ClickBusketButton();
            marketPage.ClickBusketProduct();
        }
        public void CloseWarninigAndAdvForMarket()
        {
            KufarMarketPage marketPage = new KufarMarketPage(driver);
            marketPage.GoToMainPage();
            marketPage.GoToProductPage();
            marketPage.ClosingPolicyAndAdvertisingWindows();
        }
        public string GetMarketPageTitle()
        {
            KufarMarketPage page = new KufarMarketPage(driver);
            return page.GetPageTitle();
        }
        public void ChangeRegion()
        {
            KufarPage page = new KufarPage(driver);
            Thread.Sleep(3000);
            page.ChangeRegionToGrodno();
        }
        public void InputSearch()
        {
            KufarPage page = new KufarPage(driver);
            page.InputSomeProductInSearch();
        }
        public string GetProductRegion()
        {
            KufarPage page = new KufarPage(driver);
            return page.GetRegionOfProductPage();
        }
        public void OpenSubmitAndEnteringDescription(User user)
        {
            KufarPage kufarPage = new KufarPage(driver);
            kufarPage.ClickSignInButton();
            kufarPage.Login(user);
            kufarPage.EnteringSymbolsInDescriptionField();
        }
        public string GetValueFromDescription()
        {
            KufarPage kufarPage = new KufarPage(driver);
            return kufarPage.GetValueField();
        }
        public void AuthorizeUser(User user)
        {
            KufarPage kufarPage = new KufarPage(driver);
            kufarPage.GoToMainPage();
            kufarPage.ClosingPolicyAndAdvertisingWindows();
            kufarPage.ClickSignInButton();
            kufarPage.Login(user);
            kufarPage.CloseSecondAd();
        }

        public void ClickProfileIcon()
        {
            KufarPage kufarPage = new KufarPage(driver);
            kufarPage.ClickProfileIcon();
        }
        public void ClickProfileSettings()
        {
            KufarPage kufarPage = new KufarPage(driver);
            kufarPage.ClickProfileSettings();
        }
        public void ClickSaveChanges()
        {
            AccountPage accountPage = new AccountPage(driver);
            accountPage.SaveChanges();
        }


        public void OpenAccountSettings()
        {
            AccountPage accountPage = new AccountPage(driver);
            Thread.Sleep(3000);
            accountPage.GoToMainPage();
        }
        public void InputBadName()
        {
            AccountPage accountPage = new AccountPage(driver);
            accountPage.InputBadName();
        }
        
        public void InputBadDateOfBirth()
        {
            AccountPage accountPage = new AccountPage(driver);
            accountPage.InputBadDateOfBirth();
        }


        public string GetAccountName()
        {
            AccountPage accountPage = new AccountPage(driver);
            return accountPage.GetAccountName();
        }

        public string GetBirthDateError()
        {
            AccountPage accountPage = new AccountPage(driver);
            return accountPage.GetBirthDateError();
        }
        public void PutBadSeller()
        {
            KufarPage kufarPage = new KufarPage(driver);
            Thread.Sleep(2000);
            kufarPage.PutSeller();
        }
        public string GetSeller()
        {
            KufarPage kufarPage = new KufarPage(driver);
            return kufarPage.GetSeller();
        }
        public void PutBadNumber()
        {
            KufarPage kufarPage = new KufarPage(driver);
            Thread.Sleep(2000);
            kufarPage.PutBadNumber();
        }
        public string GetNumber()
        {
            KufarPage kufarPage = new KufarPage(driver);
            return kufarPage.GetNumber();
        }
        public string GetNameOfProductFromSearch()
        {
            KufarPage kufarPage = new KufarPage(driver);
            return kufarPage.GetNameOfProductFromSearch();
        }
        public void InputSomeSearch()
        {
            KufarPage page = new KufarPage(driver);
            page.InputSomeWordsInSearch();
        }
        public void ClickOnFilter()
        {
            Thread.Sleep(15000);
            KufarPage kufarPage = new KufarPage(driver);
            kufarPage.ClickOnFilter();
        }
        public string GetCurrentFilterName()
        {
            KufarPage kufarPage = new KufarPage(driver);
            return kufarPage.GetCurrentFilterName();
        }
        public string GetCurrentFilterAndRegionName()
        {
            KufarPage kufarPage = new KufarPage(driver);
            return kufarPage.GetCurrentFilterAndRegionName();
        }









    }
}
