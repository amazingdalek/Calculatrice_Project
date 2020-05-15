using GalaSoft.MvvmLight;
using System.Windows;

namespace Calculatrice_project.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand ButtonHide { get; set; }
        public RelayCommand ButtonShow { get; set; }
        private Visibility _isHideNavBar = Visibility.Collapsed;
        public Visibility IsHideNavBar
        {
            get
            {
                return _isHideNavBar;
            }
            set
            {
                _isHideNavBar = value;
                RaisePropertyChanged();
            }
        }
        private Visibility _isShowNavBar = Visibility.Visible;
        public Visibility IsShowNavBar
        {
            get
            {
                return _isShowNavBar;
            }
            set
            {
                _isShowNavBar = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            ButtonHide = new RelayCommand(o => BtnHideShowNav("Hide"));
            ButtonShow = new RelayCommand(o => BtnHideShowNav("Show"));
        }
        private void BtnHideShowNav(string type)
        {
            if(type.Equals("Hide"))
            {
                IsHideNavBar = Visibility.Collapsed;
                IsShowNavBar = Visibility.Visible;
            }
            if (type.Equals("Show"))
            {
                IsHideNavBar = Visibility.Visible;
                IsShowNavBar = Visibility.Collapsed;
            }
        }
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
                    IsNormal = false;
                    PaveTactileScVisi = Visibility.Visible;
                    PaveTactileVisi = Visibility.Collapsed;
                }
                BtnHideShowNav("Hide");
                RaisePropertyChanged("IsNormal");


            }
        }
        private bool _isNormal = true;
        public bool IsNormal
        {
            get
            {
                return _isNormal;
            }
            set
            {
                _isNormal = value;
                if (IsNormal == true)
                {
                    IsScientifique = false;
                    PaveTactileScVisi = Visibility.Collapsed;
                    PaveTactileVisi = Visibility.Visible;
                }
                BtnHideShowNav("Hide");
                RaisePropertyChanged("IsScientifique");

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


    }
}