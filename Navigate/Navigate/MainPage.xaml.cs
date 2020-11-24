using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout bib = new StackLayout();

            Button esmBtn = new Button { Text = "Es." };
            esmBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(esmBtn);
            Button teisBtn = new Button { Text = "Te." };
            teisBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(teisBtn);
            Button kolmBtn = new Button { Text = "Ko." };
            kolmBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(kolmBtn);
            Button neljBtn = new Button { Text = "Ne." };
            neljBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(neljBtn);
            Button redBtn = new Button { Text = "Re." };
            redBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(redBtn);
            Button sbBtn = new Button { Text = "La." };
            sbBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(sbBtn);
            Button vsmBtn = new Button { Text = "Pu." };
            vsmBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(vsmBtn);

            Content = bib;
        }

        private async void Btn_clik(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Es.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new esmasp());
                    break;
            }
            switch (btn.Text)
            {
                case "Te.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new vtornik());
                    break;
            }
            switch (btn.Text)
            {
                case "Ko.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new sreda());
                    break;
            }

            switch (btn.Text)
            {
                case "Ne.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new chetverk());
                    break;
            }

            switch (btn.Text)
            {
                case "Re.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new pjatnitsa());
                    break;
            }

            switch (btn.Text)
            {
                case "La.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new subbota());
                    break;
            }

            switch (btn.Text)
            {
                case "Pü.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new voscresenie());
                    break;
            }
        }
}
}
