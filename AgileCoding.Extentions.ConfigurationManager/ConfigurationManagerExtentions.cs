namespace AgileCoding.Extentions.ConfigurationManagers
{
    using System.Configuration;
    using System.IO;
    using AgileCoding.Extentions.Files;

    public static class ConfigurationManagerExtentions
    {
        public static Configuration GetDLLConfiguration(string DLLNameAndExtention)
        {
            string detectedApp = "Application";
            if (!DLLNameAndExtention.ToLower().EndsWith(".dll"))
            {
                throw new ConfigurationErrorsException($"DLL Name '{DLLNameAndExtention}' doesnt end with the '.dll' extention. I need the FULL dll name in order to load the dll config.");
            }

            var rootConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            FileInfo rootConfigFile = new FileInfo(rootConfig.FilePath);
            var rigthConfigFile = string.Empty;
            if (rootConfigFile.Name.ToLower().EndsWith($".exe.config"))
            {
                //Its a application running, so the DLL configfiles should sit in the root
                rigthConfigFile = $@"{rootConfigFile.Directory.FullName}\{DLLNameAndExtention}";
            }
            else if (rootConfigFile.Name.ToLower().EndsWith($"web.config"))
            {
                detectedApp = "Web Applicaiton";
                //Its a WEB application running, so the DLL configfiles should sit in the bin
                rigthConfigFile = $@"{rootConfigFile.Directory.FullName}\bin\{DLLNameAndExtention}";
            }
            rigthConfigFile.ThrowIfFileDoesntExist<ConfigurationErrorsException>($"Unable to find config file for {detectedApp} at '{rigthConfigFile}'");

            return ConfigurationManager.OpenExeConfiguration(rigthConfigFile);
        }
    }
}
