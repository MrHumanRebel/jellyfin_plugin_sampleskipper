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
            bool nameHasSample = fileInfo.Name.Contains("sample", StringComparison.OrdinalIgnoreCase);
            bool pathHasSample = (fileInfo.FullName ?? string.Empty).Contains("sample", StringComparison.OrdinalIgnoreCase);

            if (fileInfo.IsDirectory)
            {
                if (nameHasSample)
                {
                    _logger.LogInformation("[SampleSkipper] Ignoring directory: {Path}", fileInfo.FullName);
                    return true;
                }

                return false;
            }

            if (nameHasSample || pathHasSample)
            {
                _logger.LogInformation("[SampleSkipper] Ignoring file: {Path}", fileInfo.FullName);
                return true;
            }

            return false;
        }
    }
}
