using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHandlerAndroidBug.ViewModels;

public class BoysPageViewModel
{
    private ObservableCollection<Person> _boys = new();
    public ObservableCollection<Person> Boys => _boys;
    public BoysPageViewModel()
    {
        _boys.Add(new Person("George"));
        _boys.Add(new Person("Paul"));
        _boys.Add(new Person("Michael"));
        _boys.Add(new Person("Peter"));
        _boys.Add(new Person("Simon"));
        _boys.Add(new Person("Edward"));
    }
}

public class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public String Name { get; set; }
}
