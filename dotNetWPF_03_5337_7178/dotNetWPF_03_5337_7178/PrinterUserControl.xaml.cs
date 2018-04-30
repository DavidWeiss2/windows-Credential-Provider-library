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

namespace dotNetWPF_03_5337_7178
{
    /// <summary>
    /// Interaction logic for PrinterUserControl.xaml
    /// </summary>
    public partial class PrinterUserControl : UserControl
    {
        public PrinterUserControl()
        {
            PrinterName = "Printer " + (++NUMBER_OF_PRINTERS);
            InitializeComponent();
        }

        public static double MAX_INK { get => 100; }
        public static double MIN_ADD_INK { get =>   MAX_INK / 4.0;}
        public static double MAX_PRINT_INK { get =>  MAX_INK / 100;}
        public static int MAX_PAGES { get =>  400;}
        public static int MIN_ADD_PAGES { get =>  MAX_PAGES / 4;}
        public static int MAX_PRINT_PAGES { get =>  MAX_PAGES / 10;}
        public static int NUMBER_OF_PRINTERS { get => 0; private set => NUMBER_OF_PRINTERS= value; }

        private string printerName;
        private double inkCount;
        private int pageCount;

        public string PrinterName { get => printerName;private set => printerName = value; }
        public double InkCount { get => inkCount; private set => inkCount = value; }
        public int PageCount { get => pageCount; private set => pageCount = value; }


        public event EventHandler<PrinterEventArgs> PageMissing;
        public event EventHandler<PrinterEventArgs> InkEmpty;

        private void inkCountProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }

    public class PrinterEventArgs
    {
        private bool isCrit;
        DateTime time;
        string message;
        string printerName;

        PrinterEventArgs(string PrinterName, string Message, bool IsCrit)
        {
            isCrit = IsCrit;
            time = System.DateTime.Now;
            message = Message;
            printerName = PrinterName;
        }

        public bool IsCrit { get => isCrit; }
        public DateTime Time { get => time; }
        public string Message { get => message; }
        public string PrinterName { get => printerName; }
    }
}
