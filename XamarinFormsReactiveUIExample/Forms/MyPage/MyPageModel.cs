using System;
using ReactiveUI;

namespace XamarinFormsReactiveUIExample
{
	public class MyPageModel : ReactiveObject
	{
		public MyPageModel ()
		{

		}

		// see http://jen20.com/blog/2013/05/29/reactive-ui-part-2-inotifypropertychanged/
		// apparently we can't have lower case _firstName?

		private string _userName = "";

		public string UserName {
			get { return _userName; }
			set { this.RaiseAndSetIfChanged (ref _userName, value); }
		}

		private string _password = default(string);

		public string Password {
			get { return _password; }
			set { this.RaiseAndSetIfChanged (ref _password, value); }
		}

	}
}

