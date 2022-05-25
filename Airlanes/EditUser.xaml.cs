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
using Airlanes.DataSetAirlinesTableAdapters;

namespace Airlanes
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        OfficesTableAdapter OfficesTableAdapter = new OfficesTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        Administrator main;
        UsersViewTableAdapter usersViewTableAdapter = new UsersViewTableAdapter();
        int id;
        public EditUser(Administrator main, string id)
        {
            InitializeComponent();
            this.main = main;
            this.id = Convert.ToInt32(id);
            office.ItemsSource = OfficesTableAdapter.GetData();
            string emaill = usersTableAdapter.Email(Convert.ToInt32(id));
            email.Text = emaill;
            string firstname = usersTableAdapter.FirstName(Convert.ToInt32(id));
            first_name.Text = firstname;
            string lasttname = usersTableAdapter.LastName(Convert.ToInt32(id));
            last_name.Text = lasttname;
            int? office_id = usersTableAdapter.Office(Convert.ToInt32(id));
            string office_title = OfficesTableAdapter.Title(Convert.ToInt32(office_id));
            office.Text = office_title;

        }

        private void cansel_Click(object sender, RoutedEventArgs e)
        {
            main.IsEnabled = true;
            Close();
        }

        private void apply_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(first_name.Text))
            {
                errors.AppendLine("Укажите имя");
            }
            if (string.IsNullOrWhiteSpace(last_name.Text))
            {
                errors.AppendLine("Укажите фамилию");
            }
            if (string.IsNullOrWhiteSpace(office.Text))
            {
                errors.AppendLine("Выберите офис");
            }
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                errors.AppendLine("Укажите email");
            }
            else
            {
                string emaill = email.Text;
                if (!emaill.Contains('@'))
                    errors.AppendLine("Укажите верный формат email адреса");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
            }
            else
            {
                string office_name = office.Text;
                int id_office = Convert.ToInt32(OfficesTableAdapter.ID(office_name));
                usersTableAdapter.UpdateUser(2,email.Text,first_name.Text, last_name.Text, id_office, id);
                main.dg_admin_user.ItemsSource = usersViewTableAdapter.GetData();
                main.IsEnabled = true;
                Close();
            }
        }
    }
}
