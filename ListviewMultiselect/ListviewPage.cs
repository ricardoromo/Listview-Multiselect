using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using ListviewMultiselect.ViewModels;

namespace ListviewMultiselect
{
	public class ListviewPage : ContentPage
	{
		ObservableCollection <ListViewModel> ListItems { get; set;} = new ObservableCollection<ListViewModel> {
			new ListViewModel{Text = "Item 1"},
			new ListViewModel{Text = "Item 2"},
			new ListViewModel{Text = "Item 3"},
			new ListViewModel{Text = "Item 4"},
			new ListViewModel{Text = "Item 5"},
			new ListViewModel{Text = "Item 6"},
			new ListViewModel{Text = "Item 7"},
			new ListViewModel{Text = "Item 8"},
			new ListViewModel{Text = "Item 9"}
		};

		ListView ListView { get; set;}

		public ListviewPage ()
		{
			ListView = new ListView ();
			ListView.ItemsSource = ListItems;
			ListView.ItemTemplate =  new DataTemplate (typeof(CustomCell));
			ListView.ItemTapped += MenuListView_ItemTapped;

			var ListViewLayout = new StackLayout ();
			ListViewLayout.Padding = new Thickness (10, 20);
			ListViewLayout.Children.Add (ListView);
			Content = ListViewLayout;
		}

		void MenuListView_ItemTapped (object sender, ItemTappedEventArgs e)
		{
			if ((sender as ListView).SelectedItem == null)
				return;
			(sender as ListView).SelectedItem = null;

			var item = e.Item as ListViewModel;
            if (item.IsSelected)
                item.IsSelected = false;
            else
            {
                foreach (var listitem in ListItems)
                    listitem.IsSelected = false;

                item.IsSelected = true;
            }
		}
	}
}

