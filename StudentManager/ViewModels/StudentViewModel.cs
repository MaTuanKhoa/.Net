using System.ComponentModel;
using System.Text.Json;
using System.Windows.Input;
using StudentManger.Models;


namespace StudentManger.ViewModel;

internal class StudentViewModel
{
    public BindingList<Student> Students { get; set; } = [
        //new Student { Name = "Student 1", Grade = "Class 1", Description = "Description 1", PhoneNum = "0123456789", Year = 2005 },
        //new Student { Name = "Student 2", Grade = "Class 2", Description = "Description 2", PhoneNum = "0123456789", Year = 2004 },
        //new Student { Name = "Student 3", Grade = "Class 3", Description = "Description 3", PhoneNum = "0123456789", Year = 2005 },
        //new Student { Name = "Student 4", Grade = "Class 4", Description = "Description 4", PhoneNum = "0123456789", Year = 2005 },
        //new Student { Name = "Student 5", Grade = "Class 5", Description = "Description 5", PhoneNum = "0123456789", Year = 2004},
        ];

    public Student? Current { get; set; }
    //
    //
    //Command
    //
    //
    public RelayCommand AddCommand { get; set; }
    public RelayCommand RemoveCommand { get; set; }
    public RelayCommand SaveCommand { get; set; }
    //
    //
    //Command Code
    //
    //
    public StudentViewModel()
    {
        //initialize students
        var json = File.ReadAllText("students.json");
#pragma warning disable CS8601
        Students = JsonSerializer.Deserialize<BindingList<Student>>(json);
#pragma warning restore CS8601
        if (Students == null)
        {
            Students = new BindingList<Student>();
        }

        //Add Button
        AddCommand = new RelayCommand((o) =>
        {
            var count = 1;
            foreach (var student in Students)
            {
                count++;
            }
            Students.Add(new Student { Name = $"Student {count}", Grade = $"Class {count}", Description = $"Description {count}", PhoneNum = "0123456789", Year = 2004 }
    );
        }, (o) => true);

        //Remove Button
        RemoveCommand = new RelayCommand((o) =>
        {
            if (Current != null)
            {
                Students.Remove(Current);
            }
        }, (o) => true);

        //Save Button
        SaveCommand = new RelayCommand((o) =>
        {
            try
            {

                var json = JsonSerializer.Serialize(Students);
                string filePath = "students.json";
                File.WriteAllText(filePath, json);
                MessageBox.Show($"Data saved to {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }, (o) => true);
    }
}
//
//
//RelayCommand
//
//
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8767
class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Func<object, bool> _canExecute;

    public RelayCommand(Action<object> execute, Func<object, bool>? canExecute = null)

    {
        _execute = execute;
        _canExecute = canExecute;
    }
    public event EventHandler? CanExecuteChanged;
    public bool CanExecute(object parameter) => _canExecute(parameter);
    public void Execute(object parameter) => _execute(parameter);
#pragma warning restore CS8601
#pragma warning restore CS8618
#pragma warning restore CS8767

}

