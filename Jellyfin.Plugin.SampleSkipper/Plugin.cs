using System;
using MediaBrowser.Common.Plugins;

namespace Jellyfin.Plugin.SampleSkipper
{
    public class Plugin : BasePlugin
    {
        // This GUID must be unique. I generated one for you, but you can change it.
        public override Guid Id => Guid.Parse("a4f5d6e7-1b2c-4d3e-5f6g-7h8i9j0k1l2m");

        public override string Name => "Sample Skipper";

        public override string Description => "Ignores video files with the word 'sample' in the filename.";

        // The instance allows other parts of the code to access the plugin if needed
        public static Plugin Instance { get; private set; }

        public Plugin(MediaBrowser.Common.ApplicationHost.IApplicationPaths applicationPaths, MediaBrowser.Common.Configuration.IXmlSerializer xmlSerializer) 
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }
    }
}
