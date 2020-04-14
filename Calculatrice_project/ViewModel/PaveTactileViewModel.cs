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
        public RelayCommand ButtonCommand0 { get; set; }
        public RelayCommand ButtonCommand1 { get; set; }
        public RelayCommand ButtonCommand2 { get; set; }
        public RelayCommand ButtonCommand3 { get; set; }
        public RelayCommand ButtonCommand4 { get; set; }
        public RelayCommand ButtonCommand5 { get; set; }
        public RelayCommand ButtonCommand6 { get; set; }
        public RelayCommand ButtonCommand7 { get; set; }
        public RelayCommand ButtonCommand8 { get; set; }
        public RelayCommand ButtonCommand9 { get; set; }
        public RelayCommand ButtonCommandPlus { get; set; }
        public RelayCommand ButtonCommandMoins { get; set; }
        public RelayCommand ButtonCommandMult { get; set; }
        public RelayCommand ButtonCommandDivi { get; set; }
        public RelayCommand ButtonCommandPourc { get; set; }
        public RelayCommand ButtonCommandVirgu { get; set; }
        public RelayCommand ButtonCommandEff { get; set; }
        public RelayCommand ButtonCommandSupp { get; set; }
        public RelayCommand ButtonCommandEgal { get; set; }

        private int numero;
        public PaveTactileViewModel()
        {
            ButtonCommand0 = new RelayCommand(o => ButtonOnclick(0));
            ButtonCommand1 = new RelayCommand(o => ButtonOnclick(1));
            ButtonCommand2 = new RelayCommand(o => ButtonOnclick(2));
            ButtonCommand3 = new RelayCommand(o => ButtonOnclick(3));
            ButtonCommand4 = new RelayCommand(o => ButtonOnclick(4));
            ButtonCommand5 = new RelayCommand(o => ButtonOnclick(5));
            ButtonCommand6 = new RelayCommand(o => ButtonOnclick(6));
            ButtonCommand7 = new RelayCommand(o => ButtonOnclick(7));
            ButtonCommand8 = new RelayCommand(o => ButtonOnclick(8));
            ButtonCommand9 = new RelayCommand(o => ButtonOnclick(9));
           
            ButtonCommandPlus = new RelayCommand(o => ButtonOnclick("+"));
            ButtonCommandMoins = new RelayCommand(o => ButtonOnclick("-"));
            ButtonCommandMult = new RelayCommand(o => ButtonOnclick("*"));
            ButtonCommandDivi = new RelayCommand(o => ButtonOnclick("/"));
            ButtonCommandPourc = new RelayCommand(o => ButtonOnclick("%"));
            ButtonCommandVirgu = new RelayCommand(o => ButtonOnclick(","));
            ButtonCommandEff = new RelayCommand(o => ButtonOnclick("eff"));
            ButtonCommandSupp = new RelayCommand(o => ButtonOnclick("supp"));
            ButtonCommandEgal = new RelayCommand(o => ButtonOnclick("="));

        }

        private void ButtonOnclick(object sender)
        {
            MessageBox.Show(sender.ToString());
        }

        public int Numero { get => numero; set => numero = value; }
    }
}
