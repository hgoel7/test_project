using System;
namespace Cymax_API_test.Models
{
	public class svc3DTO
	{
		public svc3DTO(string source, string destination, Double[] packages)
		{
			_source = source;
			_destination = destination;
			_packages = packages;
		}

		public string _source;
		public string _destination;

		public Double[] _packages;
	}
}

