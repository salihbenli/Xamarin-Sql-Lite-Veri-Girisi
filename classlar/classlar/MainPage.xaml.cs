using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace classlar
{
    public partial class MainPage : ContentPage
    {
        readonly IList<Person> model = new ObservableCollection<Person>();
        public MainPage()
        {
            InitializeComponent();
            LoadData();
        }
        protected override void OnAppearing()
        {
            PopulatePersonList();
        }


        public void PopulatePersonList()
        {
            PersonList.ItemsSource = null;
            LoadData();
        }

        private void AddPerson(object sender, EventArgs e)
        {
            Navigation.PushAsync(new personalKayıt());
        }

        private void EditPerson(object sender, ItemTappedEventArgs e)
        {
            Person details = e.Item as Person;
            if (details != null)
            {
                Navigation.PushAsync(new AddPerson(details));
            }
        }

        private async void DeletePerson(object sender, EventArgs e)
        {
            bool res = await DisplayAlert("Mesaj", "Silmek isteğinize emin misiniz?", "Evet", "Hayır");
            if (res)
            {
                var menu = sender as MenuItem;
                Person details = menu.CommandParameter as Person;
                DependencyService.Get<Database>().DeletePerson(details.Id);
                PopulatePersonList();
            }
        }
        public async void LoadData()
        {
            this.IsBusy = true;
            try
            {
                model.Clear();
                await Task.Delay(1000);  
                PersonList.ItemsSource = DependencyService.Get<Database>().GetPeople();
            }
            finally
            {
                this.IsBusy = false;
            }
        }
    }
}
