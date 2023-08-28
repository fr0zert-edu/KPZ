using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Strategy.Image
{
    public static class ImageChecker
    {
        public static bool IsLink(string input)
        {
            Uri uriResult;
            return Uri.TryCreate(input, UriKind.Absolute, out uriResult) &&
                   (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        public static bool IsFilePath(string input)
        {
            return System.IO.File.Exists(input);
        }
    }
}