using System.Net;
using System.Text;
using MyShopping.Web.Models;
using MyShopping.Web.Service.Contract;
using MyShopping.Web.Services.Contract;
using Newtonsoft.Json;

namespace MyShopping.Web.Services
{
	public class BaseService : IBaseService
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly ITokenProvider _tokenProvider;

		public BaseService(
			IHttpClientFactory httpClientFactory,
			ITokenProvider tokenProvider
		)
		{
			_httpClientFactory = httpClientFactory;
			_tokenProvider = tokenProvider;
		}

		public async Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true)
		{
			try
			{
				HttpClient client = _httpClientFactory.CreateClient("MyShoppingAPI");
				HttpRequestMessage message = new();
				message.Headers.Add("Accept", "application/json");
				message.Method = requestDto.HttpMethod;

				if (withBearer)
				{
					var token = _tokenProvider.GetToken();
					message.Headers.Add("Authorization", $"Bearer {token}");
				}

				message.RequestUri = new Uri(requestDto.Url);
				if (requestDto.Data != null)
				{
					message.Content = new StringContent(JsonConvert.SerializeObject(requestDto.Data), Encoding.UTF8, "application/json");
				}

				HttpResponseMessage? apiResponse = await client.SendAsync(message);

				switch (apiResponse.StatusCode)
				{
					case HttpStatusCode.NotFound:
						return new() { IsSuccess = false, Message = "Access Denied" };
					case HttpStatusCode.Unauthorized:
						return new() { IsSuccess = false, Message = "Unauthorized" };
					case HttpStatusCode.InternalServerError:
						return new() { IsSuccess = false, Message = "Internal Server Error" };
					default:
						var apiContent = await apiResponse.Content.ReadAsStringAsync();
						var apiResponseDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
						return apiResponseDto;
				}
			}
			catch (Exception ex)
			{
				var dto = new ResponseDto
				{
					Message = ex.Message,
					IsSuccess = false,
				};
				return dto;
			}
		}
	}
}
