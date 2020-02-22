/* Dale Shewfelt's Computer Parts assignment
 * 2/21/2020
 * This program collects imput based upon which checkboxes are checked and displays information about several computer parts.
 */
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

namespace _193937Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double total;
        double cpu;
        double cpuc;
        double mtb;
        double mem;
        double stg;
        double vcd;
        double cse;
        double pwr;
        double dvd;
        double windows10h;
        double windows10p;
        double windows98;
        double gglpxl;
        public MainWindow()
        {
            InitializeComponent();
            total = 0;
            cpu = 234.99;
            cpuc = 50.94;
            mtb = 103.99;
            mem = 122.99;
            stg = 140.61;
            vcd = 209.99;
            cse = 64.98;
            pwr = 86.99;
            dvd = 27.99;
            windows10h = 208.08;
            windows10p = 199.99;
            windows98 = 1.00;
            gglpxl = 22.99;

        }

        private void CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void chkCPU_Unchecked(object sender, RoutedEventArgs e)
        {
            cpuDetails.Visibility = Visibility.Collapsed;
            cpuImage.Visibility = Visibility.Collapsed;
            cpuMoney.Visibility = Visibility.Collapsed;
            cpuLink.Visibility = Visibility.Collapsed;
            total -= cpu;
        }

        private void chkMTB_Unchecked(object sender, RoutedEventArgs e)
        {
            mtbDetails.Visibility = Visibility.Collapsed;
            mtbImage.Visibility = Visibility.Collapsed;
            mtbMoney.Visibility = Visibility.Collapsed;
            mtbLink.Visibility = Visibility.Collapsed;
            total -= mtb;
        }

        private void chkMTB_Checked(object sender, RoutedEventArgs e)
        {
            mtbDetails.Visibility = Visibility.Visible;
            mtbImage.Visibility = Visibility.Visible;
            mtbMoney.Visibility = Visibility.Visible;
            mtbLink.Visibility = Visibility.Visible;
            total += mtb;
        }

        private void chkCPU_Checked(object sender, RoutedEventArgs e)
        {
            cpuDetails.Visibility = Visibility.Visible;
            cpuImage.Visibility = Visibility.Visible;
            cpuMoney.Visibility = Visibility.Visible;
            cpuLink.Visibility = Visibility.Visible;
            total += cpu;
        }

        private void chkCPUC_Checked(object sender, RoutedEventArgs e)
        {
            cpucDetails.Visibility = Visibility.Visible;
            cpucImage.Visibility = Visibility.Visible;
            cpucMoney.Visibility = Visibility.Visible;
            cpucLink.Visibility = Visibility.Visible;
            total += cpuc;
        }

        private void chkCPUC_Unchecked(object sender, RoutedEventArgs e)
        {
            cpucDetails.Visibility = Visibility.Collapsed;
            cpucImage.Visibility = Visibility.Collapsed;
            cpucMoney.Visibility = Visibility.Collapsed;
            cpucLink.Visibility = Visibility.Collapsed;
            total -= cpuc;
        }

        private void chkMEM_Checked(object sender, RoutedEventArgs e)
        {
            memDetails.Visibility = Visibility.Visible;
            memImage.Visibility = Visibility.Visible;
            memMoney.Visibility = Visibility.Visible;
            memLink.Visibility = Visibility.Visible;
            total += mem;
        }

        private void chkMEM_Unchecked(object sender, RoutedEventArgs e)
        {
            memDetails.Visibility = Visibility.Collapsed;
            memImage.Visibility = Visibility.Collapsed;
            memMoney.Visibility = Visibility.Collapsed;
            memLink.Visibility = Visibility.Collapsed;
            total -= mem;
        }

        private void chkSTG_Checked(object sender, RoutedEventArgs e)
        {
            stgDetails.Visibility = Visibility.Visible;
            stgImage.Visibility = Visibility.Visible;
            stgMoney.Visibility = Visibility.Visible;
            stgLink.Visibility = Visibility.Visible;
            total += stg;
        }

        private void chkSTG_Unchecked(object sender, RoutedEventArgs e)
        {
            stgDetails.Visibility = Visibility.Collapsed;
            stgImage.Visibility = Visibility.Collapsed;
            stgMoney.Visibility = Visibility.Collapsed;
            stgLink.Visibility = Visibility.Collapsed;
            total -= stg;
        }

        private void chkVCD_Checked(object sender, RoutedEventArgs e)
        {
            vcdDetails.Visibility = Visibility.Visible;
            vcdImage.Visibility = Visibility.Visible;
            vcdMoney.Visibility = Visibility.Visible;
            vcdLink.Visibility = Visibility.Visible;
            total += vcd;
        }

        private void chkVCD_Unchecked(object sender, RoutedEventArgs e)
        {
            vcdDetails.Visibility = Visibility.Collapsed;
            vcdImage.Visibility = Visibility.Collapsed;
            vcdMoney.Visibility = Visibility.Collapsed;
            vcdLink.Visibility = Visibility.Collapsed;
            total -= vcd;
        }

        private void chkCSE_Checked(object sender, RoutedEventArgs e)
        {
            cseDetails.Visibility = Visibility.Visible;
            cseImage.Visibility = Visibility.Visible;
            cseMoney.Visibility = Visibility.Visible;
            cseLink.Visibility = Visibility.Visible;
            total += cse;
        }

        private void chkCSE_Unchecked(object sender, RoutedEventArgs e)
        {
            cseDetails.Visibility = Visibility.Collapsed;
            cseImage.Visibility = Visibility.Collapsed;
            cseMoney.Visibility = Visibility.Collapsed;
            cseLink.Visibility = Visibility.Collapsed;
            total -= cse;
        }

        private void chkPWR_Checked(object sender, RoutedEventArgs e)
        {
            pwrDetails.Visibility = Visibility.Visible;
            pwrImage.Visibility = Visibility.Visible;
            pwrMoney.Visibility = Visibility.Visible;
            pwrLink.Visibility = Visibility.Visible;
            total += pwr;
        }

        private void chkPWR_Unchecked(object sender, RoutedEventArgs e)
        {
            pwrDetails.Visibility = Visibility.Collapsed;
            pwrImage.Visibility = Visibility.Collapsed;
            pwrMoney.Visibility = Visibility.Collapsed;
            pwrLink.Visibility = Visibility.Collapsed;
            total -= pwr;
        }

        private void chkDVD_Checked(object sender, RoutedEventArgs e)
        {
            dvdDetails.Visibility = Visibility.Visible;
            dvdImage.Visibility = Visibility.Visible;
            dvdMoney.Visibility = Visibility.Visible;
            dvdLink.Visibility = Visibility.Visible;
            total += dvd;
        }

        private void chkDVD_Unchecked(object sender, RoutedEventArgs e)
        {
            dvdDetails.Visibility = Visibility.Collapsed;
            dvdImage.Visibility = Visibility.Collapsed;
            dvdMoney.Visibility = Visibility.Collapsed;
            dvdLink.Visibility = Visibility.Collapsed;
            total -= dvd;
        }

        private void chkOS_Checked(object sender, RoutedEventArgs e)
        {
            osDetails.Visibility = Visibility.Visible;
            Windows10h.Visibility = Visibility.Visible;
            osLinux.Visibility = Visibility.Visible;
            Windows10p.Visibility = Visibility.Visible;
            Windows98.Visibility = Visibility.Visible;
        }

        private void chkOS_Unchecked(object sender, RoutedEventArgs e)
        {
            osDetails.Visibility = Visibility.Collapsed;
            Windows10h.Visibility = Visibility.Collapsed;
            osLinux.Visibility = Visibility.Collapsed;
            Windows10p.Visibility = Visibility.Collapsed;
            Windows98.Visibility = Visibility.Collapsed;
        }

        private void price_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = total.ToString("$0.00");
            MessageBox.Show(total.ToString("Your total is $0.00"));
        }

        private void windows10h_Checked(object sender, RoutedEventArgs e)
        {
            total += windows10h;
            w10homeMoney.Visibility = Visibility.Visible;
        }

        private void windows10h_Unchecked(object sender, RoutedEventArgs e)
        {
            w10homeMoney.Visibility = Visibility.Collapsed;
            total -= windows10h;
        }

        private void osLinux_Checked(object sender, RoutedEventArgs e)
        {
            linuxMoney.Visibility = Visibility.Visible;
            MessageBox.Show("I bet Tux could take the android alien in a fight");
            tux.Visibility = Visibility.Visible;
        }

        private void osLinux_Unchecked(object sender, RoutedEventArgs e)
        {
            linuxMoney.Visibility = Visibility.Collapsed;
            tux.Visibility = Visibility.Collapsed;
        }

        private void windows10p_Checked(object sender, RoutedEventArgs e)
        {
            w10proMoney.Visibility = Visibility.Visible;
            total += windows10p;
        }

        private void windows10p_Unchecked(object sender, RoutedEventArgs e)
        {
            w10proMoney.Visibility = Visibility.Collapsed;
            total -= windows10p;
        }

        private void Windows98_Checked(object sender, RoutedEventArgs e)
        {
            w98proMoney.Visibility = Visibility.Visible;
            total += windows98;
        }

        private void Windows98_Unchecked(object sender, RoutedEventArgs e)
        {
            w98proMoney.Visibility = Visibility.Collapsed;
            total -= windows98;
        }

        private void chkPxl_Checked(object sender, RoutedEventArgs e)
        {
            pxlDetails.Visibility = Visibility.Visible;
            pxlImage.Visibility = Visibility.Visible;
            pxlMoney.Visibility = Visibility.Visible;
            pxlLink.Visibility = Visibility.Visible;
            total += gglpxl;

        }

        private void chkPxl_Unchecked(object sender, RoutedEventArgs e)
        {
            pxlDetails.Visibility = Visibility.Collapsed;
            pxlImage.Visibility = Visibility.Collapsed;
            pxlMoney.Visibility = Visibility.Collapsed;
            pxlLink.Visibility = Visibility.Collapsed;
            total -= gglpxl;
        }
    }
}


