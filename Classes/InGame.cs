using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrnlAPI;
using WeAreDevs_API;

namespace Null.Classes
{
    internal class InGame
    {
        static Properties.Settings settings = Properties.Settings.Default;
        static KrnlApi krnl = new KrnlApi();
        static ExploitAPI wrd = new ExploitAPI();

        public static void InGameSystem(bool checkstate,string script,string closescript)
        {
            if(checkstate == true)
            {
                if(RobloxPID.RobloxGetPID() != 0)
                {
                    if (settings.SelectedAPI == 1 && krnl.IsInjected() == true)
                    {
                        krnl.Execute(script);
                    }
                    else if (settings.SelectedAPI == 1 && krnl.IsInjected() == false)
                    {

                    }
                    if (settings.SelectedAPI == 2 && wrd.isAPIAttached() == true)
                    {
                        wrd.SendLuaScript(script);
                    }
                    else if (settings.SelectedAPI == 2 && wrd.isAPIAttached() == false)
                    {

                    }
                }
            }
            else
            {
                if (settings.SelectedAPI == 1 && krnl.IsInjected() == true)
                {
                    krnl.Execute(closescript);
                }
                else if (settings.SelectedAPI == 1 && krnl.IsInjected() == false)
                {

                }
                if (settings.SelectedAPI == 2 && wrd.isAPIAttached() == true)
                {
                    wrd.SendLuaScript(closescript);
                }
                else if (settings.SelectedAPI == 2 && wrd.isAPIAttached() == false)
                {

                }
            }
        }
    }
}
