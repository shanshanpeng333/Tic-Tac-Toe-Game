//Group Six, Assignment 7 Tic-Tac-Toe Game
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

namespace Tic_Tac_Toe_Game_Button_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            vm.Button1Click(vm.getClick()[0,0]);
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            vm.Button2Click(vm.getClick()[0,1]);
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            vm.Button3Click(vm.getClick()[0,2]);
        }

        private void BtnFour_Click(object sender, RoutedEventArgs e)
        {
            vm.Button4Click(vm.getClick()[1,0]);
        }

        private void BtnFive_Click(object sender, RoutedEventArgs e)
        {
            vm.Button5Click(vm.getClick()[1,1]);
        }

        private void BtnSix_Click(object sender, RoutedEventArgs e)
        {
            vm.Button6Click(vm.getClick()[1,2]);
        }

        private void BtnSeven_Click(object sender, RoutedEventArgs e)
        {
            vm.Button7Click(vm.getClick()[2,0]);
        }

        private void BtnEight_Click(object sender, RoutedEventArgs e)
        {
            vm.Button8Click(vm.getClick()[2,1]);
        }

        private void BtnNine_Click(object sender, RoutedEventArgs e)
        {
            vm.Button9Click(vm.getClick()[2,2]);
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            vm.NewGame();
        }
    }
}
