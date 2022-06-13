using System;
namespace Cymax_API_test.Models
{
	public class svc2DTO
	{
		public svc2DTO(string consignee, string consignor, Double[] cartons)
		{
			_consignee = consignee;
			_consignor = consignor;
			_cartons = cartons;
		}

		public string _consignee;
		public string _consignor;
		public Double[] _cartons;
	}
}

