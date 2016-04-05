using System;
using System.Collections.ObjectModel;

namespace MasterApp
{
	public class PromotionViewModel
	{
		public ObservableCollection<Promotion> Promotions { get; set; }

		public PromotionViewModel()
		{
			Promotions = new ObservableCollection<Promotion>(Promotion.GetPromotions());
		}

	}
}

