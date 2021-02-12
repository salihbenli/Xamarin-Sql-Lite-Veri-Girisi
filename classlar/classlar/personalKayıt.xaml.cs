using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace classlar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class personalKayıt : ContentPage
    {
        public personalKayıt()
        {
            InitializeComponent();
        }

        private void SavePerson(object sender, EventArgs e)
        {
            Person prson = new Person();
            prson.Name = name.Text;
            prson.borc = borc.Text;
            prson.verilen = verilen.Text;

            bool res = DependencyService.Get<Database>().SavePerson(prson);
            if (res)
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Mesaj", "Kayıt Başarısız!!!", "Ok");
            }
            name.Text = string.Empty;
            borc.Text = string.Empty;
            verilen.Text = string.Empty;
        }
    }
}