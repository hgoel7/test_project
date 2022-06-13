using System;
using System.Text;
using System.Text.Json;
using Cymax_API_test.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Cymax_API_test.ApiConsumers
{
	public class Service2Consumer
	{
		private readonly HttpClient _httpClient;

		public Service2Consumer(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<int> getDeal(svc2DTO requestData)
		{
			var body = new StringContent(
				JsonSerializer.Serialize(requestData),
				Encoding.UTF8,
				Application.Json);

			var response = await _httpClient.GetAsync("users/aspnet/repos");

			response.EnsureSuccessStatusCode();

			using var responseStream = await response.Content.ReadAsStreamAsync();
			return await JsonSerializer.DeserializeAsync
				<int>(responseStream);
		}
	}
}

