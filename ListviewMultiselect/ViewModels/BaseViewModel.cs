using System;
using System.ComponentModel;

namespace ListviewMultiselect
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		public BaseViewModel ()
		{
		}
	}
}

