# Updater
This app was created for Crypto Notepad, but can be used in any C# project. This app just downloading archive with update files from server, and unzip this archive.

# How to use
Here is some code explanations:
* Enter your values for these variables.
* Build the project binaries, and place `Updater.exe` to resources of project, that you want to update.

```csharp
string appName = "Crypto Notepad.exe";
string zipName = "Crypto-Notepad-Update.zip";
string updateDownloadPath = "https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/Crypto-Notepad-Update.zip";
string releaseNotesLink = "https://github.com/Crypto-Notepad/Crypto-Notepad/wiki/Release-Notes";
```

### Sample code for check the updates and start the updating:

```csharp
private void CheckForUpdates()
{
    WebClient client = new WebClient();
    Stream stream = client.OpenRead("https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/version.txt");
    StreamReader reader = new StreamReader(stream);
    string content = reader.ReadToEnd();
    string version = Application.ProductVersion;
    string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";
    int appVersion = Convert.ToInt32(version.Replace(".", "")), serverVersion = Convert.ToInt32(content.Replace(".", ""));
    if (serverVersion > appVersion)
    {
      DialogResult res = MessageBox.Show("New version is available. Install it now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
      if (res == DialogResult.Yes)
      {
          File.WriteAllBytes(exePath + "Updater.exe", Properties.Resources.Updater);
          var pr = new Process();
          pr.StartInfo.FileName = exePath + "Updater.exe";
          pr.StartInfo.Arguments = "/u";
          pr.Start();
          Application.Exit();
      }          
    }
    if (serverVersion <= appVersion)
    {        
        MessageBox.Show("App is up to date.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}      
```
In this code you need just replace this link `https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/version.txt` (where server version stored in format 1.0.0.0) to your own.
