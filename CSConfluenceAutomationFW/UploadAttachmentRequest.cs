﻿using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConfluenceAutomationFW
{
    public class UploadAttachmentRequest : Ac4yServiceRequest
    {
        public string Password { get; set; }
        public string Username { get; set; }
        public string URL { get; set; }
        public string SpaceKey { get; set; }
        public string PageTitle { get; set; }
        public string FileName { get; set; }
        public string ImageFileBase64String { get; set; }
    }
}
