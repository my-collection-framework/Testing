﻿using Bridge;

namespace ClientTestLibrary.Utilities
{
    [FileName("utilities.js")]
    public class BrowserHelper
    {
        public static bool IsPhantomJs()
        {
            return Script.Get<string>("navigator.userAgent").Contains("PhantomJS");
        }

        public static string GetBrowserInfo()
        {
            var userAgent = Script.Get<string>("navigator.userAgent");
            var appVersion = Script.Get<string>("navigator.appVersion");
            var product = Script.Get<string>("navigator.product");
            var appName = Script.Get<string>("navigator.appName");
            var appCodeName = Script.Get<string>("navigator.appCodeName");

            return string.Format("userAgent:{0} appVersion:{1} product:{2} appName:{3} appCodeName:{4}",
                userAgent, appVersion, product, appName, appCodeName);
        }
    }
}
