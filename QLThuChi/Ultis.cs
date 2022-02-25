using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLThuChi
{
    class Ultis
    {
        public void ShowMessBox(string Messesge, string BoxSelectionStatus)
        {
            if (BoxSelectionStatus.Equals("Info"))
            {
                MessageBox.Show(Messesge, BoxSelectionStatus, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (BoxSelectionStatus.Equals("Warning"))
            {
                MessageBox.Show(Messesge, BoxSelectionStatus, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
