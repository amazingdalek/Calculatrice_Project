using Calculatrice_project.ViewModel;
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
using Calculatrice_project.ViewModel;

namespace Calculatrice_project.View.Composant
{
    /// <summary>
    /// Logique d'interaction pour PaveTactilUserControl.xaml
    /// </summary>
    public partial class PaveTactilUserControl : UserControl
    {
        public PaveTactilUserControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            Focus();
        }
    }
}
