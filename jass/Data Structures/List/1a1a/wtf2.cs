//css_import uninstall

using System;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;

namespace WindowsApplication
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				CreateConsole.Loader.create();
			}
			else
			{
				CreateConsole.Loader.attach(Convert.ToInt32(args[0]));
			}

			//bool redirected = CreateConsole.Loader.IsOutputRedirected();

			//if (!redirected)
			//{
				//
			//} // if

			//if (args.Length == )
			
			Console.WriteLine("Hello2!");
		}
	}
}