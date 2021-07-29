using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace friends_betting_app
{
    class EmployeeListViewModel
    {
        public ICommand AddEmployeeCommand => new Command(AddEmployee);
        public ICommand RemoveEmployeeCommand => new Command(RemoveEmployee);
        public ObservableCollection<string> Employees { get; set; }
        public string EmployeeName { get; set; }
        public string SelectedEmployee { get; set; }
        

        public EmployeeListViewModel()
        {
            //string[] arrEmployees = new string[] { "Rob Finnerty", "Bill Wrestler", "Gert-Beth Hopper", "Keith joyce-Purdy", "Sheri Spruce", "Burt Indybrick" };
            //Employees = arrEmployees;

            Employees = new ObservableCollection<string>();

            Employees.Add("Rob Finnerty");
            Employees.Add("Bill Wrestler");
            Employees.Add("Gert-Beth Hopper");
            Employees.Add("Keith joyce-Purdy");
            Employees.Add("Sheri Spruce");
            Employees.Add("Burt Indybrick");



        }
        public void AddEmployee()
        {
            Employees.Add(EmployeeName);

        }
        public void RemoveEmployee()
        {

            Employees.Remove(SelectedEmployee);
        }

    }
}
