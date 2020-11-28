using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.soru
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class UstHesap
    {
        public int deger;
        public int sonuc=1;
        public void Hesap()
        {
            for (int i = 0; i < 2; i++)
            {
                sonuc *= deger;
            }
        }
        public int get_set
        {
            get
            {
                return sonuc;
            }
            set
            {
                deger =value;
            }
            
        }
    }
}
