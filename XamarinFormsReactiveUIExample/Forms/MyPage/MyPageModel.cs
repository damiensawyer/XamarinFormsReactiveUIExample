﻿using System;
using ReactiveUI;

namespace XamarinFormsReactiveUIExample
{
	public class MyPageModel : ReactiveObject
	{
		private string _userName = "";

		public string UserName {
			get { return _userName; }
			set { this.RaiseAndSetIfChanged (ref _userName, value); }
		}
	}
}

