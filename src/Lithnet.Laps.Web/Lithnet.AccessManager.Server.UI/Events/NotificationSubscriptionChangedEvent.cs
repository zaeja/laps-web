﻿using System;
using System.Collections.Generic;
using System.Text;
using Lithnet.AccessManager.Configuration;

namespace Lithnet.AccessManager.Server.UI
{
    public class NotificationSubscriptionChangedEvent
    {
        public ModificationType ModificationType { get; set; }

        public NotificationChannelDefinition ModifiedObject {get;set;}
    }
}
