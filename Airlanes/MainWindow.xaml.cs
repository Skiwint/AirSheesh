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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Airlanes.DataSetAirlinesTableAdapters;

namespace Airlanes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSetAirlines dataSetAirlines;
        UsersTableAdapter usersTableAdapter;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        int time = 10;
        int countries = 0;
        public MainWindow()
        {
            InitializeComponent();
            dataSetAirlines = new DataSetAirlines();
            usersTableAdapter = new UsersTableAdapter();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
       }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (username.Text != "" && password.Password != "")
            {
                int? id_user = usersTableAdapter.Login(username.Text, password.Password);
                if(id_user != null)
                {
                    if(true == usersTableAdapter.Active(username.Text, password.Password).Value)
                    {

                        if(1 == usersTableAdapter.Role(username.Text, password.Password))
                        {
                            Administrator stateTable = new Administrator();
                            Close();
                            stateTable.Show();
                        }
                        else
                        {
                            Users stateTable = new Users();
                            Close();
                            stateTable.Show();
                        }
                    }
                    else
                    {
                        errors.Text = "Ваша учётная запись была аннулирована администрацией";
                    }
                }
                else
                {
                    if(countries == 2)
                    {
                        time = 10;
                        btn_login.IsEnabled = false;
                        timer.Start();
                        countries = 0;
                    }
                    else
                    {
                        errors.Text = "Логин или пароль неверный, попробуйте ещё раз";
                        countries++;
                    }

                }
            }
            else
            {
                errors.Text = "Введите логин и/или пароль";
            }
        }
        private void timerTick(object sender, EventArgs e)
        {
            errors.Text = "Повторите попытку через " + time + " cекунд";
            time--;
            if(time == 0)
            {
                btn_login.IsEnabled = true;
                errors.Text = "";
                timer.Stop();
            }
        }
    }
}
