<div align="center">

# Jellyfin Sample Skipper

*A lightweight, automated plugin for Jellyfin that keeps your library clean.*

<p align="center">
  <img
    src="https://raw.githubusercontent.com/MrHumanRebel/jellyfin_plugin_sampleskipper/main/sampleskipper.png"
    alt="Sample Skipper Banner"
    width="200"
  />
</p>

</div>

---

## ✨ Overview

Sample Skipper is a simple yet powerful plugin designed to automatically detect and ignore **"sample" video files** during library scans.  

No more manual cleanup or cluttered folders — if a file has `sample` in its name, this plugin ensures it never reaches your Jellyfin library.

---

## 🚀 Features

- **Automatic Detection** – Seamless integration with the Jellyfin library scanner, ignoring both files and directories containing "sample".
- **Case Insensitive** – Detects `sample`, `Sample`, `SAMPLE`, or any variation.  
- **Zero Config** – Install it and forget it; it works out of the box.  
- **Lightweight** – Minimal impact on scan performance.  

---

## 📦 Installation

### Option 1: Official Repository (Recommended)

1. Open your **Jellyfin Dashboard**.  
2. Navigate to **Plugins → Repositories**.  
3. Click **(+) Add Repository**.  
4. Enter the following details:

   - **Name:** `Sample Skipper Repo`  
   - **URL:**  
     `https://raw.githubusercontent.com/MrHumanRebel/jellyfin_plugin_sampleskipper/main/manifest.json`

5. Go to the **Catalog** tab, find **Sample Skipper**, and click **Install**.  
6. **Restart Jellyfin** to load the plugin.

---

### Option 2: Manual Installation

1. Download the latest `.zip` release from the **Releases** page.  
2. Extract the `Jellyfin.Plugin.SampleSkipper.dll` file.  
3. Place the file into your Jellyfin plugins folder:

   - **Linux:** `/var/lib/jellyfin/plugins/`  
   - **Windows:** `%ProgramData%\Jellyfin\Server\plugins\`

4. **Restart** the Jellyfin server.

---

## 🛠️ Building from Source

### Requirements

- [.NET 9.0.10 SDK](https://dotnet.microsoft.com/)

### Steps

```bash
# Clone the repository
git clone https://github.com/MrHumanRebel/jellyfin-plugin-sampleskipper.git

# Enter the directory
cd jellyfin-plugin-sampleskipper

# Build the project
dotnet build Jellyfin.Plugin.SampleSkipper/Jellyfin.Plugin.SampleSkipper.csproj --configuration Release
```
## 🤝 Contributing

Contributions, issues, and feature requests are welcome!
Feel free to check the issues page.

## 📄 License

Distributed under the MIT License.
See LICENSE for more information.

## Made with ❤️ for the Jellyfin Community


