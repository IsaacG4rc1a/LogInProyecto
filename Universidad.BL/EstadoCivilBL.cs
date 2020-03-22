using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class EstadoCivilBL
	{
		ContextoBD _contex;

		public BindingList<EstadoCivil> ListaEC { get; set; }

		public EstadoCivilBL()
		{
			_contex = new ContextoBD();
			ListaEC = new BindingList<EstadoCivil>();
		}

		public BindingList<EstadoCivil> ObtenerEC()
		{
			_contex.tbEstadoCivil.Load();
			ListaEC = _contex.tbEstadoCivil.Local.ToBindingList();

			return ListaEC; 
		}
	}
}
