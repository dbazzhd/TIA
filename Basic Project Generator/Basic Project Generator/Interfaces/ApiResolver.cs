using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;

namespace Basic_Project_Generator.Interfaces
{
    public static class ApiResolver
    {
        #region constants

        public const string Version = "V17";
        private const string LibraryKey = "SOFTWARE\\Siemens\\Automation\\Openness\\17.0\\PublicAPI\\17.0.0.0";
        private const string LibraryName = "Siemens.Engineering";

        #endregion // constants

        #region methods

        /// <summary>
        /// Determines the API library to be loaded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Assembly AssemblyResolver(object sender, ResolveEventArgs args)
        {
            var lookupName = new AssemblyName(args.Name);
            if (lookupName.Name.Equals(LibraryName, StringComparison.OrdinalIgnoreCase))
            {
                var libraryFilePath = GetLibraryFilePath();
                if (!string.IsNullOrWhiteSpace(libraryFilePath))
                {
                    var suggestedName = AssemblyName.GetAssemblyName(libraryFilePath);
                    return Assembly.Load(suggestedName);
                }
            }
            return null;
        }

        /// <summary>
        /// Determines if the version of the API library is installed
        /// </summary>
        /// <returns></returns>
        public static bool IsOpennessInstalled()
        {
            return !string.IsNullOrWhiteSpace(GetLibraryFilePath());
        }

        private static string GetLibraryFilePath()
        {
            using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (var registryKey = baseKey.OpenSubKey(LibraryKey, RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.ReadKey))
                {
                    var libraryFilePath = registryKey?.GetValue(LibraryName) as string;
                    if (!string.IsNullOrWhiteSpace(libraryFilePath) && File.Exists(libraryFilePath))
                    {
                        return libraryFilePath;
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
