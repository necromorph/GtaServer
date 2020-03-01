﻿using GTANetworkAPI;

namespace Server
{
    public class Server : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void ResourceStart()
        {
            NAPI.Util.ConsoleOutput("FivePalmRP: Server has been loaded!");
        }
    }
}