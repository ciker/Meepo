﻿using System;
using System.Net;

namespace Meepo.Core.Configs
{
    public struct TcpAddress
    {
        public IPAddress IPAddress { get; }

        public int Port { get; }

        public TcpAddress(IPAddress ipAddress, int port)
        {
            IPAddress = ipAddress ?? throw new ArgumentNullException(nameof(ipAddress));
            Port = port;
        }
    }
}

