﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.Demo
{
    public class MyHub1 : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}