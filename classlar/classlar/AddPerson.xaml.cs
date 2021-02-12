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
    public partial class AddPerson : ContentPage
    {
        
        Person personGel;
        public AddPerson(Person details)
        {
            InitializeComponent();
                if (details != null)
                {
                    personGel = details;
                    aktarim(personGel);
                }  
        }
        private void aktarim(Person details)
        {
            name.Text = details.Name;
            borc.Text = details.borc;
            verilen.Text = details.verilen;
           

        }
        public async void btn_git(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private void EditPerson(object sender, EventArgs e)
             {
                 personGel.Name = name.Text;
                 personGel.borc = borc.Text;
                 personGel.verilen = verilen.Text;

                 bool res = DependencyService.Get<Database>().UpdatePerson(personGel);
                 if (res)
                 {
                     DisplayAlert("Mesaj", "Güncelleme Başarılı!!!", "Ok");
                 }
                 else
                 {
                     DisplayAlert("Mesaj", "Güncelleme Başarısız!!!", "Ok");
                 }
                name.Text = string.Empty;
                borc.Text = string.Empty;
                verilen.Text = string.Empty;
        }
    }
}