using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Data.Entity;
using System.ComponentModel;

namespace EmployeeAppTestTask
{
    /// <summary>
    /// Interaction logic for WindowAddEmployee.xaml
    /// </summary>
    public partial class WindowAddEmployee : Window
    {
        private MainWindow _mainWindow;

        public delegate void UpdateData();
        public WindowAddEmployee(MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
        }

        public void Button_AddEmployeeConfirm(object sender, RoutedEventArgs e)
        {          
            using (EmployeeDataEntities employeeContex = new EmployeeDataEntities())
            {
                var name = TexBox_Name.Text;
                var surname = TextBox_Surname.Text;
                var thirdName = TextBox_ThirdName.Text;

                bool isEmpty = (name == "" ^ surname == "" ^ thirdName == "");
                if (isEmpty)
                {
                    MessageBox.Show("Одно из полей пустое!");
                }
                else
                {
                    Employee employee = new Employee()
                    {
                        Name = name,
                        Surname = surname,
                        ThirdName = thirdName
                    };

                    employeeContex.Employees.Add(employee);
                    employeeContex.SaveChanges();

                    MessageBox.Show($"Пользователь {employee.Surname} {employee.Name} {employee.ThirdName} успешно добавлен!");

                    _mainWindow.employeeGrid.Items.Refresh();
                }
            }

            _mainWindow.employeeGrid.Items.Refresh();
            this.Close();
        }

        void Closing_WindowAppEmployee(object sender, CancelEventArgs e)
        {
            _mainWindow.employeeGrid.Items.Refresh();
        }
    }
}
