using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;

namespace Calculatrice_project.ViewModel
{
    public class PaveTactileViewModel : ViewModelBase
    {
        public int numero;
        public RelayCommand ButtonCommand1 { get; set; }
        public PaveTactileViewModel()
        {
            ButtonCommand1 = new RelayCommand(o => Button1Onclick(1));
        }
        private void Button1Onclick(object sender)
        {
            MessageBox.Show(sender.ToString());
        }
    }
}
