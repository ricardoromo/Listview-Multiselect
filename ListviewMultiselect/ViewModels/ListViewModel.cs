using System;
using Xamarin.Forms;

namespace ListviewMultiselect.ViewModels
{
	public class ListViewModel : BaseViewModel
	{
		public ListViewModel ()
		{
		}

		string text;
		public string Text{
			get{
				return text;
			}set{
				text = value;
				OnPropertyChanged("Text");
			}
		}

		bool isselected;
		public bool IsSelected{
			get{
				return isselected;
			}set{
				isselected = value;
				OnPropertyChanged("IsSelected");
				OnPropertyChanged(nameof(TextColor));
				OnPropertyChanged(nameof(DetailImage));
			}
		}

		public Color TextColor
		{
			get{
				if(IsSelected){
					return Color.FromRgb(77,200,233);
				}
				return Color.Black;
			}
		}
			
		public string DetailImage
		{
			get{
				if(IsSelected){
					return "detail1";
				}
				return "detail";
			}
		}
	}
}

