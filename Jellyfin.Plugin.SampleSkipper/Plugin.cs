using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.SampleSkipper
{
    public class Plugin : BasePlugin
    {
        public override Guid Id => Guid.Parse("a4f5d6e7-1b2c-4d3e-5f6g-7h8i9j0k1l2m");

        public override string Name => "Sample Skipper";

        public override string Description => "Ignores video files with the word 'sample' in the filename.";

        public static Plugin Instance { get; private set; }

        // FIX: The BasePlugin constructor in Jellyfin 10.11.3 no longer requires IXmlSerializer.
        // We only pass IApplicationPaths to the base class.
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) 
            : base(applicationPaths) 
        {
            Instance = this;
        }
    }
}
