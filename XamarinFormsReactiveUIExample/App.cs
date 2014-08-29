using System;
using FormsGallery;
using Xamarin.Forms;

namespace XamarinFormsReactiveUIExample
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage(new MenuPage());
		}
	}
}

