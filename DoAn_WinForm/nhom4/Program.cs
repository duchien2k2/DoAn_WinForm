using DevExpress.XtraEditors;
using nhom4.Models; // Chỉ thêm nếu cần dùng lớp User hoặc lớp khác trong Models
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowsFormsSettings.DefaultFont = new Font("Tahoma", 8.25f);
            Application.Run(new Form_Login());
        }
    }
}
