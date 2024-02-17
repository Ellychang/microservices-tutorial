using static MangoWeb.Utils.SD;

namespace MangoWeb.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; }
        public string Url  { get; set; }
        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
