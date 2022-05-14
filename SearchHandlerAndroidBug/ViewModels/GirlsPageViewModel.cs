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
    public GirlsPageViewModel(int group=0)
    {

        if (group == 0)
        {
            _girls.Add(new Person("Gina"));
            _girls.Add(new Person("Pauline"));
            _girls.Add(new Person("Michele"));
            _girls.Add(new Person("Petra"));
            _girls.Add(new Person("Sally"));
            _girls.Add(new Person("Elaine"));
        }
        else
        {
            _girls.Add(new Person("Grace"));
            _girls.Add(new Person("Francoise"));
            _girls.Add(new Person("Gertrude"));
            _girls.Add(new Person("Tifany"));
            _girls.Add(new Person("Sandra"));
            _girls.Add(new Person("Eloise"));
        }
    }
}
