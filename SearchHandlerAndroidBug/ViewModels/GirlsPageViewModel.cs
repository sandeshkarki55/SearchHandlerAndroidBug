using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHandlerAndroidBug.ViewModels;

public class GirlsPageViewModel
{
    private List<Person> _girls = new(6);
    public List<Person> Girls => _girls;
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
