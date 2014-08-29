using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ReactiveUI;
using ReactiveUI.XamForms;

namespace XamarinFormsReactiveUIExample
{
	public partial class HelloWorldPage : ReactiveContentPage<HelloWorldPageModel>
	{
		public HelloWorldPage ()
		{
			InitializeComponent ();
			this.ViewModel = new HelloWorldPageModel();

			this.Bind (ViewModel, vm => vm.UserName, v => v.userNameEntry.Text);
			this.OneWayBind (ViewModel, vm => vm.UserName, v => v.userNameLabel.Text);

		}
	}
}

