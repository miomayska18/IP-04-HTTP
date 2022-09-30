using MiniServer.HTTP;
using MiniServer.WebServer;
using System.IO;
using System.Text;

namespace MiniServer.Demo
{
    public class HomeController
    {
        public IHttpResponse Index(IHttpRequest request)
        {
            string content = "<h1>Hello, World!</h1>";
            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
