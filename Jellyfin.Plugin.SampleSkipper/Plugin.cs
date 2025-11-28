using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Model.Plugins; // Important: This is needed for PluginInfo!

namespace Jellyfin.Plugin.SampleSkipper
{
    public class Plugin : BasePlugin
    {
        // IMPORTANT: This GUID MUST MATCH the one in manifest.json!
        public override Guid Id => Guid.Parse("5826df63-32c0-4822-9218-403d67f5370d");

        public override string Name => "Sample Skipper";

        public override string Description => "Ignores video files with the word 'sample' in the filename.";

        public static Plugin Instance { get; private set; }

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) 
            : base() 
        {
            Instance = this;
        }

        // FIX: We override GetPluginInfo to avoid BasePlugin crash in 10.11.x
        public override PluginInfo GetPluginInfo()
        {
            return new PluginInfo
            {
                Name = this.Name,
                Version = this.Version,
                CanUninstall = true, // Enable uninstallation
                Description = this.Description,
                Id = this.Id
            };
        }
    }
}
