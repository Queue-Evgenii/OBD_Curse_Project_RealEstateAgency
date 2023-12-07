using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace RealEstateAgency
{
    public partial class App : Form
    {
        /* Global methods */
        public static byte[] getImageBytesFromWeb(string path)
        {
            try
            {
                WebClient webClient = new WebClient();
                return webClient.DownloadData(path);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
