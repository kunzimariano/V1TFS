﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VersionOneTFSServer.Collections
{
    /// <summary>
    /// The set of textual keys used to define settings in the webconfig.
    /// </summary>
    public struct AppSettingKeys
    {
        public const string WindowsIntegratedSecurity = "V1_Integrated";
        public const string VersionOneUrl = "V1_Url";
        public const string UserName = "V1_UserName";
        public const string Password = "V1_Password";
        public const string ProxyEnabled = "V1_ProxyEnabled";
        public const string ProxyUrl = "V1_ProxyUrl";
        public const string ProxyDomain = "V1_ProxyDomain";
        public const string ProxyUserName = "V1_ProxyUserName";
        public const string ProxyPassword = "V1_ProxyPassword";
    }
}