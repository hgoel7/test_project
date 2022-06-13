using System;
using System.Text;
using System.Text.Json;
using Cymax_API_test.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Cymax_API_test.ApiConsumers
{
	public class Service3Consumer
	{
		private readonly HttpClient _httpClient;
		public Service3Consumer(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<int> getDeal(svc3DTO requestData)
		{
			var body = new StringContent(
				JsonSerializer.Serialize(requestData),
				Encoding.UTF8,
				Application.Json);
			var response = await _httpClient.GetAsync("getDeal");

			response.EnsureSuccessStatusCode();

			using var responseStream = await response.Content.ReadAsStreamAsync();
			return await JsonSerializer.DeserializeAsync
				<int>(responseStream);
		}
	}
}

