using System;
using System.Linq;
using System.Windows.Input;
using ReactiveUI;

namespace XamarinFormsReactiveUIExample
{
    public class FilteredListPageModel : ReactiveObject
    {
        public ReactiveList<RowModel> myCollection { get; private set; }
        public ReactiveList<RowModel> filteredCollection { get; private set; }

        public FilteredListPageModel()
        {
            this.myCollection = new ReactiveList<RowModel>();
            var i = 0;
            myCollection.Add(new RowModel(true) { Name = "Cathryn", Index = i++ });
            myCollection.Add(new RowModel(false) { Name = "Damien", Index = i++ });
            myCollection.Add(new RowModel(false) { Name = "Matthew", Index = i++ });
            myCollection.Add(new RowModel(false) { Name = "Peter", Index = i++ });
            myCollection.Add(new RowModel(true) { Name = "Sienna", Index = i++ });
            myCollection.Add(new RowModel(true) { Name = "Rebkekah", Index = i++ });
        }
        public class RowModel
        {
            public RowModel(bool isFemale)
            {
                this.IsFemale = isFemale;
            }
            public string Name { get; set; }
            public int Index { get; set; }

            public bool IsFemale { get; set; }
        }
    }
}

