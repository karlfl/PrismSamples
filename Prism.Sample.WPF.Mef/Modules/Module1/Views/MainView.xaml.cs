using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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

namespace Module1.Views
{
    /// <summary>
    /// Interaction logic for Module1_MainView.xaml
    /// </summary>
    [Export(typeof(IMainView))]
    public partial class MainView : UserControl, IMainView
	{
		public MainView()
		{
			InitializeComponent();
		}
	}
}
