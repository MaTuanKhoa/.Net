using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentManger.Models;

internal class Student : INotifyPropertyChanged
{
    private string name = "new student";
    private string grade = "new class";
    private string description = "new description";
    private string phoneNum = "new num";
    private int old;

    public string Name { get => name; set => Set(ref name, value); }
    public string Description { get => description; set => Set(ref description, value); }
    public string Grade { get => grade; set => Set(ref grade, value); }
    public string PhoneNum { get => phoneNum; set => Set(ref phoneNum, value); }
    public int Year { get => old; set => Set(ref old, value); }


    void Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
    {
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;

}

