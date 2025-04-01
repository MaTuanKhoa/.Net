
using StudentManger.Models;
using StudentManger.ViewModel;

namespace StudentManger
{
    public partial class StudentView : Form
    {
        BindingSource bs = new();
        StudentViewModel vm = new();
        public StudentView()
        {
            InitializeComponent();

            bs.DataSource = vm.Students;
            dataView.DataSource = bs;

            //binding textboxes
            txtName.DataBindings.Add("Text", bs, "Name");
            txtGrade.DataBindings.Add("Text", bs, "Grade");
            txtDescription.DataBindings.Add("Text", bs, "Description");
            txtPhoneNum.DataBindings.Add("Text", bs, "PhoneNum");
            numYear.DataBindings.Add("Value", bs, "Year");

            //binding buttons
            toolAdd.Command = vm.AddCommand;
            toolRemove.Command = vm.RemoveCommand;
            toolSave.Command = vm.SaveCommand;
            dataView.SelectionChanged += delegate { vm.Current = dataView.CurrentRow.DataBoundItem as Student; };
        }
    }
}
