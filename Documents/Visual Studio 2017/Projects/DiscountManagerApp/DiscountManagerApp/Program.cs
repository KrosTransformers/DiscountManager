using System;
using System.Windows.Forms;

namespace DiscountManagerApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var discountService = new DiscountManagerService();
            var discountRepository = new DiscountRepository();
            var discountViewModel = new DiscountManagerViewModel(discountService, discountRepository);
            Application.Run(new DiscountManagerView(discountViewModel));
        }
    }
}
