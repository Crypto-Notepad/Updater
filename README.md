# Updater
Updater created for Crypto Notepad, but can be used in your own project.

# How to use
This simple app just compares file version with version from server, and if server version is higher, its updating your app. Here is some code explanations:

* Enter your values for these variables.

```csharp
public partial class UpdateForm : Form
{
  string appName = "Crypto Notepad.exe";
  string zipName = "Crypto-Notepad-Update.zip";
  string updateDownloadPath = "https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/Crypto-Notepad-Update.zip";
  string releaseNotesLink = "https://github.com/Crypto-Notepad/Crypto-Notepad/wiki/Release-Notes";
}
```

* Build project, and place `Ionic.Zip.dll` and `Updater.exe` files to resources of project what you want to update.
* Here is code for check for updates and start the updating:

```csharp
      WebClient client = new WebClient();
      Stream stream = client.OpenRead("https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/version.txt");
      StreamReader reader = new StreamReader(stream);
      string content = reader.ReadToEnd();
      string version = Application.ProductVersion;
      string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";

      int appVersion = Convert.ToInt32(version.Replace(".", "")), serverVersion = Convert.ToInt32(content.Replace(".", ""));

      if (serverVersion > appVersion)
      {
          MainMenu.Invoke((Action)delegate
          {
              using (new CenterWinDialog(this))
              {
                  DialogResult res = MessageBox.Show("New version is available. Install it now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                  if (res == DialogResult.Yes)
                  {
                      File.WriteAllBytes(exePath + "Ionic.Zip.dll", Properties.Resources.Ionic_Zip);
                      File.WriteAllBytes(exePath + "Updater.exe", Properties.Resources.Updater);

                      var pr = new Process();
                      pr.StartInfo.FileName = exePath + "Updater.exe";
                      pr.StartInfo.Arguments = "/u";
                      pr.Start();
                      Application.Exit();
                  }
              }
          });
      }

      if (serverVersion <= appVersion)
      {
          MainMenu.Invoke((Action)delegate
          {
              using (new CenterWinDialog(this))
              {
                  MessageBox.Show("Crypto Notepad is up to date.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
          });
      }
```
In this code you need just replace this link `https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/version.txt` (where stored server version in format 1.0.0.0) to your own.

* Code for delete update files:

```csharp
private void DeleteUpdateFiles()
{
    string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";
    string UpdaterExe = exePath + "Updater.exe";
    string UpdateZip = exePath + "Crypto-Notepad-Update.zip";
    string ZipDll = exePath + "Ionic.Zip.dll";

    if (File.Exists(UpdaterExe))
    {
        File.Delete(UpdaterExe);
    }

    if (File.Exists(UpdateZip))
    {
        File.Delete(UpdateZip);
    }

    if (File.Exists(ZipDll))
    {
        File.Delete(ZipDll);
    }
}
```
