using System;
namespace Cymax_API_test.Models
{
	public class svc1DTO
	{

		public svc1DTO(string contact_address, string warehouse_address, Double[] package_dimensions)
		{
			_contact_address = contact_address;
			_warehouse_address = warehouse_address;
			_package_dimensions = package_dimensions;
		}

		public string _contact_address;
		public string _warehouse_address;
		public Double[] _package_dimensions;
	}
}

