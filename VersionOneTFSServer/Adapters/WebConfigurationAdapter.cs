﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web.Configuration;

namespace VersionOneTFSServer.Adapters
{
    public static class WebConfigurationAdapter
    {

        /// <summary>
        /// Returns all appSettings from the root web config.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> GetAllAppSettings()
        {
            var configuration = GetRootWebConfig();
            var keys = configuration.AppSettings.Settings.AllKeys;
            return keys.ToDictionary(key => key, GetAppSetting);
        } 

        /// <summary>
        /// TODO:  Are these methods necessary that take a paramarray? 
        /// 
        /// Retrieves settings from the appSettings section of the root web.config file.
        /// </summary>
        /// <param name="keyNames"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetAppSettings(params string[] keyNames)
        {
            
            if (keyNames.Length == 0) return null;

            var settings = new Dictionary<string, string>();

            foreach (var key in keyNames)
            {
                settings.Add(key, GetAppSetting(key));
            }

            return settings;

        }

        public static string GetAppSetting(string key)
        {
            var configuration = GetRootWebConfig();
            var nameValuePair = configuration.AppSettings.Settings[key];
            return nameValuePair == null ? null : nameValuePair.Value;
        }

        /// <summary>
        /// Saves a set of keyvalue pairs to the appSettings element of a web.config.
        /// </summary>
        /// <param name="keyValuePairs"></param>
        public static void SaveAppSettings(Dictionary<string,string> keyValuePairs)
        {

            var configuration = GetRootWebConfig();

            foreach (var keyValuePair in keyValuePairs)
            {
                if (configuration.AppSettings.Settings[keyValuePair.Key] == null)
                {
                    configuration.AppSettings.Settings.Add(new KeyValueConfigurationElement(keyValuePair.Key, keyValuePair.Value));
                }
                else
                {
                    configuration.AppSettings.Settings[keyValuePair.Key].Value = keyValuePair.Value;
                }
            }

            SaveConfiguration(configuration);

        }

        /// <summary>
        /// Clears all appSettings from the web.config.
        /// </summary>
        public static void ClearAllAppSettings()
        {
            var configuration = GetRootWebConfig();
            ClearSettings(configuration.AppSettings.Settings.AllKeys, configuration);
        }

        public static void ClearAppSettings(params string[] keys)
        {
            ClearSettings(keys, GetRootWebConfig());
        }

        public static void ClearAppSettings(IEnumerable<string> keys)
        {
            ClearSettings(keys, GetRootWebConfig());
        }

        private static void ClearSettings(IEnumerable<string> keys, Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            var save = false;
            foreach (var key in keys)
            {
                configuration.AppSettings.Settings.Remove(key);
                save = true;
            }

            if (save == true) SaveConfiguration(configuration);

        }

        private static Configuration GetRootWebConfig()
        {
            return WebConfigurationManager.OpenWebConfiguration(null);
        }

        private static void SaveConfiguration(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            configuration.Save(ConfigurationSaveMode.Modified);
        }
    }
}