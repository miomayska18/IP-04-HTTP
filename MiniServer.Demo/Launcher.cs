using System;
using MiniServer.HTTP;
using MiniServer.WebServer;

namespace MiniServer.Demo
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add(
                HttpRequestMethod.Get,
                path:"/",
                func:request => new HomeController().Index(request));

            Server server = new Server(8080, serverRoutingTable);

            server.Run();
        }
    }
}
