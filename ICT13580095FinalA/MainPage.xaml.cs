using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580095FinalA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            newButton.Clicked+= NewButton_Clicked;
        }

		protected override void OnAppearing()
		{
			LoadData();
		}

		void LoadData()
		{
            productListView.ItemsSource = App.DbHelper.GetProducts();
		}


		void NewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductNewPage());
        }
    }
}
