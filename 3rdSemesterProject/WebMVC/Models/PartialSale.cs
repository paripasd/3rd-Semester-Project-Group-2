using System;
namespace WebMVC.Models
{
	public class PartialSale
	{
		public int GameID { get; set; }
		public string Email { get; set; }
		public float SalesPrice { get; set; }

		public PartialSale(int gameID, string email, float salesPrice)
		{
			GameID = gameID;
			Email = email;
			SalesPrice = salesPrice;
		}
	}
}

