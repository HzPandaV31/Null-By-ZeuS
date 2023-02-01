using injection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null
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
            Application.Run(new Splash());
        }
        public static string dll_path = Directory.GetCurrentDirectory() + string.Format("\\\\{0}", "krnl.dll");

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

		public static bool is_attached = false;

		public static Old_Injector.inject_status Inject()
		{
			if (Program.findpipe("krnlpipe"))
			{
				return Old_Injector.inject_status.Success;
			}
			if (!File.Exists(Program.dll_path))
			{
				return Old_Injector.inject_status.DllNotFound;
			}
			int num = 0;
			Program.GetWindowThreadProcessId(Program.FindWindowA("WINDOWSCLIENT", "Roblox"), out num);
			if (num == 0)
			{
				Program.is_attached = false;
				return Old_Injector.inject_status.ProcessNotFound;
			}
			if (Old_Injector.inject_dll((uint)num))
			{
				return Old_Injector.inject_status.Success;
			}
			return Old_Injector.inject_status.Failed;
		}
		public static bool findpipe(string pipeName)
		{
			return Program.WaitNamedPipe(Path.GetFullPath("\\\\.\\pipe\\" + pipeName), 0) || (Marshal.GetLastWin32Error() != 0 && Marshal.GetLastWin32Error() != 2);
		}
	}
}
