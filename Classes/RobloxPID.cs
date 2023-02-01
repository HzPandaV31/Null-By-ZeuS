using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null
{
    internal class RobloxPID
    {
        public static int RobloxGetPID()
        {
            Process[] pname = Process.GetProcessesByName("RobloxPlayerBeta");
            foreach (Process p in pname)
            {
                if (p.TotalProcessorTime.TotalSeconds > 3)
                {
                    if (pname.Length > 0)
                    {
                        return p.Id;
                    }
                }
            }
            return 0;
        }
        public static void ProcKill(int procID)
        {
            if(procID != 0)
            {
                Process proc = Process.GetProcessById(procID);
                proc.Kill();
            }
            else
            {
                MessageBox.Show("Roblox Not Found!","NULL",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
