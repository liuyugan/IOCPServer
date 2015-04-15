﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using IOCPServer;

namespace IOCPServer
{
    class Test
    {
        static void Main(string[] args)
        {
            //TODO 读取配置文件
            //ConfigHandler;
            ConfigHandler config = new ConfigHandler();
            config.Init("webapps\\config.xml");
            IOCPServer server = new IOCPServer(Config.SERVER_PORT, Config.MAX_CLIENT);
            server.Start();
            Console.WriteLine("服务器已启动....");
            System.Console.ReadLine();
        }
    }
}
