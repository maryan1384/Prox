using Prox.ViewModels.MainServices;
using Prox.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Diagnostics;
using System.Windows.Media;

namespace Prox.ViewModels
{
    public class MainViewModel:ViewModelBase
    {

        //private Datas
        private MainView BaseWindow;


        //Private Properties
        private ICommand _maximizeCMD;
        private ICommand _minimizeCMD;
        private ICommand _closeCMD;

        //Public Properties
        public ICommand MaximizeCMD { get => _maximizeCMD; set => _maximizeCMD = value; }
        public ICommand MinimizeCMD { get => _minimizeCMD; set => _minimizeCMD = value; }
        public ICommand CloseCMD { get => _closeCMD; set => _closeCMD = value; }

        //Constractor
        public MainViewModel()
        {
            CloseCMD = new ViewModelCommandBase(new Action<object>(OnClose));
        }

        //Methods

        private void OnClose(object obj)
        {
            BaseWindow = obj as MainView;
            BaseWindow.Close();
            Application.Current.Shutdown();
        }
    }
}
