using MyShopping.Web.Models;

namespace MyShopping.Web.Service.Contract
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
