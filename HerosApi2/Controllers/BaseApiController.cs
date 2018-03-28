using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HerosApi2.Controllers
{
    public class BaseApiController : ApiController
    {
        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }
    }
}