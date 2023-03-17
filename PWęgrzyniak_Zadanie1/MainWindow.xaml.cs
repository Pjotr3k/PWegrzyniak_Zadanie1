using PWęgrzyniakZadanie1.ViewModels;
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

namespace PWęgrzyniak_Zadanie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

            //ListProduktsXAML.Items.Add(listProduktsVM);

            InitializeComponent();

            ListProduktsVM listProduktsVM = new ListProduktsVM();
            foreach (var pil in listProduktsVM.Pils)
            {
                ListProduktsXAML.Items.Add(pil);
            }


            //ListProduktsXAML.Items.Add(listProduktsVM.pils);
        }
    }
}
