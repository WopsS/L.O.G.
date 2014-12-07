﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOG.API.Networking.Messages.Types
{
    /// <summary>
    /// Types of server messages.
    /// </summary>
    public enum ServerMessageTypes
    {
        RegisterHost,
        RequestHostList,
        RequestIntroduction
    }
}
