using System;
using Xamarin.Forms;

namespace ListviewMultiselect
{
	public class CustomCell : ViewCell
	{
		public Label CellText { get; set; }
		public Image ImageDetail { get; set;}

		public CustomCell ()
		{
			Height = 60;

			CellText = new Label ();
			CellText.FontAttributes = FontAttributes.Bold;
			CellText.SetBinding (Label.TextProperty, "Text");
			CellText.VerticalOptions = LayoutOptions.CenterAndExpand;

			ImageDetail = new Image ();
			ImageDetail.HeightRequest = 25;
			ImageDetail.WidthRequest = 25;
			ImageDetail.SetBinding (Image.SourceProperty, "DetailImage");

			var ContentCell = new StackLayout ();
			ContentCell.Children.Add (ImageDetail);
			ContentCell.Children.Add (CellText);
			ContentCell.Spacing = 10;
			ContentCell.Orientation = StackOrientation.Horizontal;

			View = ContentCell;


		}
	}
}

