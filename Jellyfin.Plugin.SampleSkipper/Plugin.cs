using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.SampleSkipper
{
    public class Plugin : BasePlugin
    {
        // This must match the GUID in manifest.json!
        public override Guid Id => Guid.Parse("5826df63-32c0-4822-9218-403d67f5370d");

        public override string Name => "Sample Skipper";

        public override string Description => "Ignores video files with the word 'sample' in the filename.";

        public static Plugin Instance { get; private set; }

        // FIX: Removed IXmlSerializer from the constructor because it causes a NullReference error at startup in 10.11!
        public Plugin(IApplicationPaths applicationPaths) 
            : base() 
        {
            Instance = this;
        }

        public override PluginInfo GetPluginInfo()
        {
            return new PluginInfo(
                this.Name,
                this.Version,
                this.Description,
                this.Id,
                true // CanUninstall
            );
        }
    }
}
