using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Csla;

namespace MyFormsApp
{
  public class Person : INotifyPropertyChanged
  {
    private string _name;
    public string Name
    {
      get { return _name; }
      set { _name = value; OnPropertyChanged("Name"); }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string name)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
  }

  // CSLA Person class - but doesn't work just yet :(
  //
  //[Serializable]
  //public class Person : BusinessBase<Person>
  //{
  //  public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
  //  public string Name
  //  {
  //    get { return GetProperty(NameProperty); }
  //    set { SetProperty(NameProperty, value); }
  //  }

  //  protected override void DataPortal_Create()
  //  {
  //    using (BypassPropertyChecks)
  //    {
  //      Name = "Teresa";
  //    }
  //  }
  //}
}