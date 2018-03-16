using System;
using Ooui;
using Xamarin.Forms;

namespace MyFormsApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Initialize Xamarin.Forms
      Forms.Init();

      // Create the UI
      var page = new Page1();
      var obj = new Person { Name = "Jessica Jones" };
      page.BindingContext = obj;

      // Publish a root element to be displayed
      UI.Publish("/", page.GetOouiElement());
    }
  }
}