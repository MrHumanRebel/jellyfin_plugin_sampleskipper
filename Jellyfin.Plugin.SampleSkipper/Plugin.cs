using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.SampleSkipper
{
    public class Plugin : BasePlugin<PluginConfiguration>
    {
        // This must match the GUID in manifest.json!
        public override Guid Id => Guid.Parse("5826df63-32c0-4822-9218-403d67f5370d");

        public override string Name => "Sample Skipper";

        public override string Description => "Ignores video files with the word 'sample' in the filename.";

        public static Plugin Instance { get; private set; }

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
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
