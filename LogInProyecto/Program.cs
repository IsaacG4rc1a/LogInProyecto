using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInProyecto
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
			Application.Run(new frmLogIn());
		}

		public static byte[] imageToArray(Image imageIn)
		{
			var ms = new MemoryStream();
			imageIn.Save(ms, imageIn.RawFormat); // FORMATO ORIGINAL DE LA IMAGEN, la guardo en memoria.

			return ms.ToArray(); // retorna la imagen como un arreglo
		} 
	}
}
