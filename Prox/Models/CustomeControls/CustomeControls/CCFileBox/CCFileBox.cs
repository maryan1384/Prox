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

namespace Prox.Models.CustomeControls.CustomeControls.CCFileBox
{
    public class CCFileBox : Button
    {
        public string FileName
        {
            get { return (string)GetValue(FileNameProperty); }
            set { SetValue(FileNameProperty, value); }
        }
        public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register("FileName", typeof(string), typeof(CCFileBox), new PropertyMetadata("Not Found"));




        static CCFileBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CCFileBox), new FrameworkPropertyMetadata(typeof(CCFileBox)));
        }
    }
}
