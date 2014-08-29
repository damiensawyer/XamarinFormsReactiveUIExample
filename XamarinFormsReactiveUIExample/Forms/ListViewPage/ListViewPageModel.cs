using System;
using System.Linq;
using System.Windows.Input;
using ReactiveUI;

namespace XamarinFormsReactiveUIExample
{
    public class ListViewPageModel : ReactiveObject
    {
        private string _userName = "";
        public ReactiveList<RowModel> myCollection { get; private set; }
        public ReactiveCommand<Object> Add { get; private set; }
        public ReactiveCommand<Object> Remove { get; private set; }
        public ReactiveCommand<Object> Add100 { get; private set; }

        public ListViewPageModel()
        {
            this.myCollection = new ReactiveList<RowModel>();
            var i = 0;
            myCollection.Add(new RowModel {Name = "Cathryn", Index = i++});
            myCollection.Add(new RowModel {Name = "Damien", Index = i++});
            myCollection.Add(new RowModel {Name = "Matthew", Index = i++});
            myCollection.Add(new RowModel {Name = "Peter", Index = i++});

            //Add = this.WhenAnyValue(x => x.Players.Count, x => x.NewPlayerName,
            //(count, newPlayerName) => count < 7 && !string.IsNullOrWhiteSpace(newPlayerName) && !this.Players.Contains(newPlayerName))
            //.ToCommand();

            this.Add = ReactiveCommand.Create();
            this.Add.Subscribe(x => this.AddDate());

            this.Remove = ReactiveCommand.Create();
            this.Remove.Subscribe(x => this.myCollection.RemoveAt(myCollection.Count - 1));

            this.Add100 = ReactiveCommand.Create();
            this.Add100.Subscribe(x =>
            {
                for (int j = 0; j < 100; j++)
                {
                    this.AddDate();
                }

            });
        }

        public void AddDate()
        {
            this.myCollection.Add(new RowModel {Name = DateTime.Now.ToString(), Index = myCollection.Count});
        }



        public class RowModel
        {
            public string Name { get; set; }
            public int Index { get; set; }
        }
    }
}

