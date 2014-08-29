using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.XamForms;

namespace XamarinFormsReactiveUIExample
{
    public partial class ListViewPage : ReactiveContentPage<ListViewPageModel>
    {
        public ListViewPage()
        {
            InitializeComponent();
            this.ViewModel = new ListViewPageModel();

            this.myCollection.ItemsSource = this.ViewModel.myCollection;
            this.BindCommand(ViewModel, x => x.Add, v => v.add);
            this.BindCommand(ViewModel, x => x.Remove, v => v.remove);
            this.BindCommand(ViewModel, x => x.Add100, v => v.add100);
            //this.OneWayBind(ViewModel, vm => vm.myCollection, v => v.myCollection.ItemsSource);
        }
    }
}
