using SearchHandlerAndroidBug.ViewModels;
using System.Collections.ObjectModel;

namespace SearchHandlerAndroidBug.Handlers;

public class PersonSearchHandler:SearchHandler
{
    public PersonSearchHandler()
    {
        /// IOS
        if (DeviceInfo.Platform == DevicePlatform.iOS)
        {
            SearchBoxVisibility = SearchBoxVisibility.Expanded;
        }
        else
        {
            SearchBoxVisibility = SearchBoxVisibility.Collapsible;
        }
    }

    public ObservableCollection<Person> Persons { get; set; }


    protected override void OnQueryChanged(string oldValue, string newValue)
    {
        base.OnQueryChanged(oldValue, newValue);
        if(Persons == null)
        {
            Persons = ItemsSource as ObservableCollection<Person>;
        }

        if (string.IsNullOrWhiteSpace(newValue))
        {
            ItemsSource = null;
        }
        else
        {
            var searchItems = newValue.ToLower().Split(' ');

            ItemsSource = (from a in Persons
             where searchItems.All(word => a.Name.ToLower().Contains(word))
             select a);
        }
    }

    protected override async void OnItemSelected(object item)
    {
        var selectedPerson = item as Person;
        base.OnItemSelected(item);
        await Task.Delay(1000); // for the code to work on IOS add delay


        if (selectedPerson == null)
            return;

        // This works because route names are unique in this application.
        //await Shell.Current.GoToAsync($"persondetail?id={selectedPerson.Name}");
        
    }

}
