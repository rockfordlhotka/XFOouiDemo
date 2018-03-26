using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent ();

      NameLabel.Text = "Loading from ctor...";
    }

    protected override void OnAppearing()
    {
      var obj = (Person)BindingContext;
      obj.Name = "Luke Cage";
    }

    internal void DoSomething()
    {
      var obj = (Person)BindingContext;
      obj.Name = "Matt Murdoch";
    }

    //private void ButtonClicked(object sender, EventArgs e)
    //{
    //  NameLabel.Text = "Button was clicked";
    //  var obj = (Person)BindingContext;
    //  obj.Name = "Luke Cage";
    //}
  }
}