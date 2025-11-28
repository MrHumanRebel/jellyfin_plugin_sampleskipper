using System;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Resolvers;
using MediaBrowser.Model.IO;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.SampleSkipper
{
    public class SampleIgnoreRule : IResolverIgnoreRule
    {
        private readonly ILogger<SampleIgnoreRule> _logger;

        public SampleIgnoreRule(ILogger<SampleIgnoreRule> logger)
        {
            _logger = logger;
        }

        public bool ShouldIgnore(FileSystemMetadata fileInfo, BaseItem parent)
        {
            // Fix: Define the condition directly or assign it to a variable
            bool nameHasSample = fileInfo.Name.Contains("sample", StringComparison.OrdinalIgnoreCase);

            if (fileInfo.IsDirectory)
            {
                // Previously this line caused the error because 'nameHasSample' was missing
                if (nameHasSample) 
                {
                    _logger.LogInformation("[SampleSkipper] Ignoring directory: {Path}", fileInfo.FullName);
                    return true;
                }

                return false;
            }

            if (nameHasSample)
            {
                _logger.LogInformation("[SampleSkipper] Ignoring file: {Path}", fileInfo.FullName);
                return true;
            }

            return false;
        }
    }
}
