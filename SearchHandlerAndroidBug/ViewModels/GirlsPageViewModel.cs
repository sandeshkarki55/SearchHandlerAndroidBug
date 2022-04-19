using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHandlerAndroidBug.ViewModels;

public class GirlsPageViewModel
{
    private ObservableCollection<Person> _girls = new();
    public ObservableCollection<Person> Girls => _girls;
    public GirlsPageViewModel()
    {
        _girls.Add(new Person("Gina"));
        _girls.Add(new Person("Pauline"));
        _girls.Add(new Person("Michele"));
        _girls.Add(new Person("Petra"));
        _girls.Add(new Person("Sally"));
        _girls.Add(new Person("Elaine"));
    }
}
