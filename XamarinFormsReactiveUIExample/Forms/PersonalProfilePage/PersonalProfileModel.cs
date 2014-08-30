using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ReactiveUI;

namespace XamarinFormsReactiveUIExample
{
    public class PersonalProfileModel : ReactiveObject
    {
        public PersonalProfileModel()
        {
            this.WhenAnyValue (x => x.Country).Subscribe(x => this.Bound = x);
        }

        #region Reactive Property Name

        private string _name;

        public string Name
        {
            get { return _name; }
            set { this.RaiseAndSetIfChanged(ref this._name, value); }
        }

        #endregion

        #region Reactive Property Birthday

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { this.RaiseAndSetIfChanged(ref this._birthday, value); }
        }

        #endregion

        #region Reactive Property Country

        private string _country;

        public string Country
        {
            get { return _country; }
            set { this.RaiseAndSetIfChanged(ref this._country, value); }
        }

        #endregion

        #region Reactive Property Bound

        private string _bound;

        public string Bound
        {
            get { return _bound; }
            set { this.RaiseAndSetIfChanged(ref this._bound, value); }
        }

        #endregion
    }
}

