using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using ListviewMultiselect.ViewModels;

namespace ListviewMultiselect
{
	public class ListviewPage : ContentPage
	{
		ObservableCollection <ListViewModel> ListItems { get; set;} = new ObservableCollection<ListViewModel> {
			new ListViewModel{Text = "Lista Tareas"},
			new ListViewModel{Text = "Insertar Tareas"},
			new ListViewModel{Text = "Buscar Tareas"}
		};

		ListView ListView { get; set;}

		public ListviewPage ()
		{

			ListView = new ListView ();
			ListView.ItemsSource = ListItems;
			ListView.RowHeight = 60;
			ListView.ItemTemplate =  new DataTemplate (typeof(CustomCell));
			ListView.ItemTapped += MenuListView_ItemTapped;

			var ListViewLayout = new StackLayout ();
			ListViewLayout.HeightRequest = 180;
			ListViewLayout.Children.Add (ListView);
			var button = new Button ();
			button.Text = "prueb";
			button.Clicked += Button_Clicked;
			ListViewLayout.Children.Add (button);
			Content = ListViewLayout;
		}

		async void Button_Clicked (object sender, EventArgs e)
		{
			foreach (var x in ListItems) {
				if (x.IsSelected) {
					await DisplayAlert("Simon",x.Text + " Esa bi","ok");
				}
			}
		}

		void MenuListView_ItemTapped (object sender, ItemTappedEventArgs e)
		{
			var x = e.Item as ListViewModel;
			if (x.IsSelected)
				x.IsSelected = false;
			else
				x.IsSelected = true;
		}
	}
}

