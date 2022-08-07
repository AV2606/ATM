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
using System.Windows.Shapes;

namespace ATMUI
{
    /// <summary>
    /// Interaction logic for WithdrawPage.xaml
    /// </summary>
    public partial class WithdrawPage : Page
    {
        string WithdrawAmount = "999";
      
        public WithdrawPage()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class WithdrawAmount
    {
        public string WithdrawAmountTextBox { get; set; }
    }
}
