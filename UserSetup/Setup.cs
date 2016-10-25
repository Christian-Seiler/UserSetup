using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace UserSetup
{
    class Setup
    {
        public string createDirectories1() {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var template = Path.Combine(appDataPath, @"Microsoft\Templates");
            Console.WriteLine(template);

            if (!Directory.Exists(template))
            {
                Directory.CreateDirectory(template);
            }

            return ("Ordner \"Templates\" erstellt.\n");
 
        }

        public string createDirectories2()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var signature = Path.Combine(appDataPath, @"Microsoft\Signatures");
            if (!Directory.Exists(signature))
            {
                Directory.CreateDirectory(signature);
            }
            return "Ordner \"Signatures\" erstellt.\n";
        }

        public string copyTemplate()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var template = Path.Combine(appDataPath, @"Microsoft\Templates\");
            var sourceTemplate = @"\\SRV01\Vorlagen\Neuinstallation\Outlook\Templates\";
            var file = "NormalEmail_" + Program.abteilung + ".dotm";

            var fileName = Path.Combine(sourceTemplate, file);
            var destFile = Path.Combine(template, "NormalEmail.dotm");

            string result = "";

            if (File.Exists(file))
            {
                if (File.Exists(destFile))
                {
                    File.Delete(destFile);
                    result = "Vorhandene Vorlage gelöscht\n";
                }
                File.Copy(fileName, destFile);
                result += $"Template \"{Program.abteilung}\" erstellt.\n";
            }
            else
            {
                result = $"Template \"{Program.abteilung}\" nicht vorhanden.\n";
            }

            return result;
        }

        public string copySignature()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var target = Path.Combine(appDataPath, @"Microsoft\Signatures\");
            var source = @"\\srv01\Vorlagen\Neuinstallation\Outlook\Signatures\Allpower\";

            foreach (string dirPath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories)) Directory.CreateDirectory(dirPath.Replace(source, target));
            foreach (string newPath in Directory.GetFiles(source, "*.*", SearchOption.AllDirectories)) File.Copy(newPath, newPath.Replace(source, target), true);

            return $"Signature kopiert.\n";
        }

        public string setDefaultPrinter()
        {
            SafeNativeMethods.SetDefaultPrinter(Program.selectedPrinter);
            return $"Drucker {Program.selectedPrinter} als Standard festgelegt.\n";
        }

        public string customizeSignature()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var signature = Path.Combine(appDataPath, @"Microsoft\Signatures");

            foreach (string file in Directory.GetFiles(signature))
            {
                var filename = Path.GetFullPath(file);
                File.WriteAllText(filename, Regex.Replace(File.ReadAllText(filename), "vorname.nachname@allpower.ch", Program.mail));
                File.WriteAllText(filename, Regex.Replace(File.ReadAllText(filename), "Vorname", Program.vorname));
                File.WriteAllText(filename, Regex.Replace(File.ReadAllText(filename), "Nachname", Program.name));
                File.WriteAllText(filename, Regex.Replace(File.ReadAllText(filename), "Abteilung", Program.abteilung));
            }

            return $"Signature für {Program.vorname} {Program.name} personalisiert.\n";
        }

        public string setRegistryEntries()
        {
            RegistryKey key;
            try
            {
                key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\14.0\\Outlook\\Setup", true);
                try
                {
                    key.DeleteValue("First-Run");
                    Console.WriteLine("Key deleted");
                    key.Close();
                }
                catch
                {
                    Console.WriteLine("Key First-Run does not exist.");
                }
            }
            catch
            {
                Console.WriteLine("Key Outlook\\Setup does not exist.");
            }

            key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\14.0\\Common\\MailSettings", true);
            if (key == null)
            {
                Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Office\\14.0\\Common\\MailSettings");
                key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Office\\14.0\\Common\\MailSettings", true);
            }


            key.SetValue("NewSignature", "Allpower", RegistryValueKind.ExpandString);
            key.SetValue("ReplySignature", "Allpower", RegistryValueKind.ExpandString);
            key.Close();

            key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main", true);
            if (key == null)
            {
                Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main");
                key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main", true);
            }

            key.SetValue("Start Page", "http://srv01.local/intranet", RegistryValueKind.String);
            key.SetValue("Secondary Start Pages", "http://srv01:8000/portal", RegistryValueKind.String);
            key.Close();

            return "Outlook Signatur wurde festgelegt.\nInternet Explorer Startseiten wurden festgelegt.\n";
        }
    }

    [SuppressUnmanagedCodeSecurity]
    internal static class SafeNativeMethods
    {
        [DllImport("winspool.drv", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
    }
}