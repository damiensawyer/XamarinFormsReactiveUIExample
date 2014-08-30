using System;
using System.Collections.Generic;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace XamarinFormsReactiveUIExample
{
    public partial class PersonalProfilePage : ReactiveContentPage<PersonalProfileModel>
    {
        public PersonalProfilePage()
        {
            InitializeComponent();
            this.ViewModel = new PersonalProfileModel();
            this.Bind(ViewModel, vm => vm.Name, v => v.name.Text);
            this.Bind(ViewModel, vm => vm.Birthday, v => v.birthday.Date);
            this.Bind(ViewModel, vm => vm.Country, v => v.country.Text);
            this.Bind(ViewModel, vm => vm.Bound, v => v.bound.Text);
        }
    }
}