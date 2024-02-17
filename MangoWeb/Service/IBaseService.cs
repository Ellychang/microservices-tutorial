using MangoWeb.Models;

namespace MangoWeb.Service
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsyc(RequestDto requestDto);
    }
}
