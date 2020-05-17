using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Calculatrice_project.Model;
using Calculatrice_project.Tools;
using GalaSoft.MvvmLight;

namespace Calculatrice_project.ViewModel
{
    public class PaveTactileViewModel : ViewModelBase
    {
        private bool _isScientifique;
        public bool IsScientifique
        {
            get
            {
                return _isScientifique;
            }
            set
            {
                _isScientifique = value;
                if (_isScientifique == true)
                {
                    PaveTactileScVisi = Visibility.Visible;
                    PaveTactileVisi = Visibility.Collapsed;
                }
                else
                {
                    PaveTactileScVisi = Visibility.Collapsed;
                    PaveTactileVisi = Visibility.Visible;
                }
            }
        }
        private Visibility _paveTactileScVisi = Visibility.Collapsed;
        public Visibility PaveTactileScVisi 
        {
            get
            {
                return _paveTactileScVisi;
            }
            set
            {
                _paveTactileScVisi = value;
                RaisePropertyChanged();
            }
        }
        private Visibility _paveTactileVisi = Visibility.Visible;
        public Visibility PaveTactileVisi
        {
            get
            {
                return _paveTactileVisi;
            }
            set
            {
                _paveTactileVisi = value;
                RaisePropertyChanged();
            }
        }
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
        public RelayCommand ButtonCommandParDroite { get; set; }
        public RelayCommand ButtonCommandParGauche { get; set; }
        public RelayCommand ButtonCommandXCarre { get; set; }
        public RelayCommand ButtonCommandXCube { get; set; }
        public RelayCommand ButtonCommandRacine { get; set; }
        public RelayCommand ButtonCommandPi { get; set; }
        public RelayCommand ButtonCommandLog { get; set; }
        public RelayCommand ButtonCommandSin { get; set; }
        public RelayCommand ButtonCommandCos { get; set; }
        public RelayCommand ButtonCommandTan { get; set; }

        private string calcul;

        private string resultat;

        private string[] lstOperateurs = { "+", "-", "*", "/"};

        private string[] lstActions = { "eff", "supp", "%", "="};

       public ObservableCollection<CalculatriceHistoriqueModel> ListHistorique { get; set; }

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

            ButtonCommandParDroite = new RelayCommand(o => ButtonOnclick(")"));
            ButtonCommandParGauche = new RelayCommand(o => ButtonOnclick("("));
            ButtonCommandXCarre = new RelayCommand(o => ButtonOnclick("^2"));
            ButtonCommandXCube = new RelayCommand(o => ButtonOnclick("^3"));
            ButtonCommandRacine = new RelayCommand(o => ButtonOnclick("sqrt("));
            ButtonCommandPi = new RelayCommand(o => ButtonOnclick("pi"));
            ButtonCommandLog = new RelayCommand(o => ButtonOnclick("log10("));
            ButtonCommandSin = new RelayCommand(o => ButtonOnclick("sin("));
            ButtonCommandCos = new RelayCommand(o => ButtonOnclick("cos("));
            ButtonCommandTan = new RelayCommand(o => ButtonOnclick("tan("));
            ListHistorique = new ObservableCollection<CalculatriceHistoriqueModel>();
        }

        private void ButtonOnclick(object sender)
        {
            Calcul = sender.ToString();
        }

        public string Calcul
        { 
            get => calcul;
            set 
            {
                if (!lstActions.Contains(value))
                {
                    calcul += value;
                    RaisePropertyChanged();
                }
                else
                {
                    if (value.Equals("="))
                    {
                        Resultat = Functions.calculerResultat(calcul);
                        ListHistorique.Insert(0, new CalculatriceHistoriqueModel
                        {
                            CalculHisto = calcul,
                            ResultatHisto = resultat
                        });
                    }
                    if (value.Equals("supp"))
                    {
                        if (!calcul.Equals(""))
                        {
                            calcul = calcul.Remove(calcul.Length - 1, 1);
                            RaisePropertyChanged();
                        }
                    }
                    if (value.Equals("eff"))
                    {
                        calcul = "";
                        Resultat = "";
                        RaisePropertyChanged();
                    }
                    if (value.Equals("%"))
                    {
                        calcul += "/100";
                        RaisePropertyChanged();
                        Resultat = String.Format("0:n", Functions.calculerResultat(calcul).ToString());
                    }
                }
            }
        }

        public string Resultat
        {
            get => resultat;
            set
            {
                resultat = value;
                RaisePropertyChanged();
            }
        }
    }
}
