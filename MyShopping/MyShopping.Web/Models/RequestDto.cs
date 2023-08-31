using static MyShopping.Web.Utility.SD;

namespace MyShopping.Web.Models
{
    public class RequestDto
    {
        public HttpMethod HttpMethod { get; set; } = HttpMethod.Get;

        public string Url { get; set; }

        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
