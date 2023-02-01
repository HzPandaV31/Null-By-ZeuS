using System;
using System.Runtime.InteropServices;
using System.Text;
using Null;

namespace injection
{
	// Token: 0x02000006 RID: 6
	public class Old_Injector
	{
		// Token: 0x0600001A RID: 26
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x0600001B RID: 27
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr hObject);

		// Token: 0x0600001C RID: 28
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x0600001D RID: 29
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x0600001E RID: 30
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x0600001F RID: 31
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x06000020 RID: 32
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		// Token: 0x06000021 RID: 33
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x06000022 RID: 34
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

		// Token: 0x06000023 RID: 35 RVA: 0x000025DC File Offset: 0x000007DC
		public static bool inject_dll(uint pid)
		{
			IntPtr intPtr = Old_Injector.OpenProcess(1082U, 1, pid);
			if (intPtr == Old_Injector.zero)
			{
				return false;
			}
			IntPtr procAddress = Old_Injector.GetProcAddress(Old_Injector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			if (procAddress == Old_Injector.zero)
			{
				return false;
			}
			IntPtr intPtr2 = Old_Injector.VirtualAllocEx(intPtr, Old_Injector.zero, (IntPtr)Program.dll_path.Length, 12288U, 64U);
			IntPtr value = Old_Injector.CreateRemoteThread(intPtr, Old_Injector.zero, Old_Injector.zero, procAddress, intPtr2, 0U, Old_Injector.zero);
			if (intPtr2 == Old_Injector.zero)
			{
				return false;
			}
			if (Old_Injector.WriteProcessMemory(intPtr, intPtr2, Encoding.ASCII.GetBytes(Program.dll_path), (uint)Encoding.ASCII.GetBytes(Program.dll_path).Length, 0) == 0)
			{
				return false;
			}
			if (value != Old_Injector.zero)
			{
				Old_Injector.CloseHandle(intPtr);
				return true;
			}
			return false;
		}

		// Token: 0x0400000D RID: 13
		public static IntPtr zero = IntPtr.Zero;

		// Token: 0x02000012 RID: 18
		public enum inject_status
		{
			// Token: 0x04000144 RID: 324
			DllNotFound,
			// Token: 0x04000145 RID: 325
			ProcessNotFound,
			// Token: 0x04000146 RID: 326
			Failed,
			// Token: 0x04000147 RID: 327
			Success,
			// Token: 0x04000148 RID: 328
			threaderr
		}
	}
}
