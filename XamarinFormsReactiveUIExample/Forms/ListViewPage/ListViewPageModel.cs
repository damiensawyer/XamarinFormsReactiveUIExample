using System;
using ReactiveUI;

namespace XamarinFormsReactiveUIExample
{
	public class ListViewPageModel : ReactiveObject
	{
		private string _userName = "";
        public ReactiveList<string> myCollection { get; private set; }
        public ReactiveCommand<Object> Add { get; private set; }
        public ReactiveCommand<Object> Remove { get; private set; }

	    public ListViewPageModel()
	    {
	        this.myCollection = new ReactiveList<string>();
            myCollection.Add("Cathryn");
            myCollection.Add("Damien");
            myCollection.Add("Matthew");
            myCollection.Add("Peter");


            //Add = this.WhenAnyValue(x => x.Players.Count, x => x.NewPlayerName,
            //(count, newPlayerName) => count < 7 && !string.IsNullOrWhiteSpace(newPlayerName) && !this.Players.Contains(newPlayerName))
            //.ToCommand();

	        this.Add = ReactiveCommand.Create();
            this.Add.Subscribe(x => this.myCollection.Add(DateTime.Now.ToString()));

            this.Remove = ReactiveCommand.Create();
            this.Remove.Subscribe(x => this.myCollection.RemoveAt(myCollection.Count -1));

	    }
	}
}

