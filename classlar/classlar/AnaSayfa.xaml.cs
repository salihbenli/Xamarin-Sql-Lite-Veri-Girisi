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
    public partial class AnaSayfa : ContentPage
    {
        public AnaSayfa()
        {
            InitializeComponent();
            Title = "AnaSayfa";
        }

        public void cari_btn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new personalKayıt());
        }
        public void cari_btn2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPerson(null));
        }
    }
}