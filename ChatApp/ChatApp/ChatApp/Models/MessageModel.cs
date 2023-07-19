﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp.Models
{
    public class MessageModel
    {
        public long ID { get; set; }
        public string UseName { get; set; }
        public string Message { get; set; }
        public bool IsOwnerMessage { get; set; }
    }
}