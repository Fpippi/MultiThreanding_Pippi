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

namespace MultiThreanding_Pippi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_task_Click(object sender, RoutedEventArgs e)
        {
            lbl_risultato.Content = "Risultato = ";
            Task.Factory.StartNew(Dowork);
        }

        public void Dowork()
        {
            for (int i = 0; i <= 100000; i++)
            {
                for (int j = 0; j <= 100000; j++)
                {
                }
            }
            Dispatcher.Invoke(AggiornaInterfaccia);
        }

        private void AggiornaInterfaccia()
        {
            lbl_risultato.Content += "Finito";
        }
    }
}
