using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;
using XamarinFormsReactiveUIExample;

namespace FormsGallery
{
    internal class MenuPage : ContentPage
    {
        public MenuPage()
        {
            // Yoinked this from the Xamarin Forms Samples
            // Define command for the items in the TableView.
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    // Get all the constructors of the page type.
                    IEnumerable<ConstructorInfo> constructors =
                        pageType.GetTypeInfo().DeclaredConstructors;

                    foreach (ConstructorInfo constructor in constructors)
                    {
                        // Check if the constructor has no parameters.
                        if (constructor.GetParameters().Length == 0)
                        {
                            // If so, instantiate it, and navigate to it.
                            Page page = (Page) constructor.Invoke(null);
                            await this.Navigation.PushAsync(page);
                            break;
                        }
                    }
                });

            this.Title = "Forms Gallery";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("")
                    {

                        new ViewCell
                        {
                            View = new ContentView // http://stackoverflow.com/a/24061564/494635
                            {
                                Padding = new Thickness(20, 0, 0, 0),
                                Content = new Label
                                {
                                    Text = "Please select...",
                                    Font = Font.SystemFontOfSize(NamedSize.Large),
                                }
                            }
                        },
                        new TextCell
                        {
                            Text = "Simple Entry to Label Binding",
                            Command = navigateCommand,
                            CommandParameter = typeof (HelloWorldPage)
                        },
                        new TextCell
                        {
                            Text = "Intro to ListView",
                            Command = navigateCommand,
                            CommandParameter = typeof (ListViewPage)
                        },      
                        new TextCell
                        {
                            Text = "Filtered List",
                            Command = navigateCommand,
                            CommandParameter = typeof (FilteredListPage)
                        },
                        new TextCell
                        {
                            Text = "Form",
                            Command = navigateCommand,
                            CommandParameter = typeof (PersonalProfilePage)
                        },
                    },
                }
            };
        }
    }
}
