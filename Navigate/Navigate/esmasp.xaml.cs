using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class esmasp : ContentPage
    {
        public esmasp()
        {
            Title = "Понедельник";
            string[] tasks = new string[] { "Tõusen püsti", "Söön putru", "Jalutan", "Lähen lõunale", "Tegelen spordiga", "Söön", "Magan" };

            ListView list = new ListView { BackgroundColor = Color.WhiteSmoke, SeparatorColor = Color.Gray, RowHeight = 50, };
            // определяем источник данных
            list.ItemsSource = tasks;

            Button bb = new Button { Text = "Назад" };
            bb.Clicked += Bb_Clicked;

            Button bbk = new Button { Text = "Вперед" };
            bbk.Clicked += Bbk_Clicked;


            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list, bb, bbk } };


        }

        string vremja;
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string text = e.SelectedItem.ToString();
            if (e.SelectedItemIndex == 0)
            {
                vremja = "7:00";
            }

            if (e.SelectedItemIndex == 1)
            {
                vremja = "10:00";
            }

            if (e.SelectedItemIndex == 2)
            {
                vremja = "12:00";
            }

            if (e.SelectedItemIndex == 3)
            {
                vremja = "14:00";
            }

            if (e.SelectedItemIndex == 4)
            {
                vremja = "18:00";
            }

            if (e.SelectedItemIndex == 5)
            {
                vremja = "19:00";
            }

            if (e.SelectedItemIndex == 6)
            {
                vremja = "20:00";
            }

            await DisplayAlert(text, vremja, "Продолжить");

            StackLayout bubi = new StackLayout();


            Button bb = new Button { Text = "Назад" };
            bb.Clicked += Bb_Clicked;
            bubi.Children.Add(bb);

            Button bbk = new Button { Text = "Вперед" };
            bbk.Clicked += Bbk_Clicked;
            bubi.Children.Add(bbk);
        }

        private async void Bbk_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new vtornik());
        }

        private async void Bb_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}