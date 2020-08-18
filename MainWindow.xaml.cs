using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeAppTestTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EmployeeDataEntities employeeContex = new EmployeeDataEntities();

            employeeContex.Employees.Load();
            employeeGrid.ItemsSource = employeeContex.Employees.Local.ToBindingList();
        }

        private void Button_AddEmployee(object sender, RoutedEventArgs e)
        {
            WindowAddEmployee windowAddEmployee = new WindowAddEmployee(this);

            windowAddEmployee.Show();

            if (!windowAddEmployee.IsActive)
            {
                employeeGrid.Items.Refresh();
            }
        }
        private void Button_DeleteEmployee(object sender, RoutedEventArgs e)
        {
            if (employeeGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выделите сотрудника, которого хотите удалить.");
            }
            else
            {
                using (EmployeeDataEntities employeeContex = new EmployeeDataEntities())
                {
                    Employee selectedItem = employeeGrid.SelectedItem as Employee;

                    Employee employee = employeeContex.Employees.FirstOrDefault(item => item.Id == selectedItem.Id);

                    employeeContex.Employees.Remove(employee);
                    employeeContex.SaveChanges();

                    employeeGrid.Items.Refresh();

                    MessageBox.Show("Сотрудник удалён");
                }
            }
        }
    }
}
