using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterApp.Pages
{
	public class MenuListData : List<MenuItem>
	{
		public MenuListData ()
		{
			this.Add (new MenuItem () {
				Titulo = "Oferta",
				TargetType = typeof(Promotions)
			});

			this.Add (new MenuItem () {
				Titulo = "Outra",
				TargetType = typeof(Outra)
			});

		}
	}
}
