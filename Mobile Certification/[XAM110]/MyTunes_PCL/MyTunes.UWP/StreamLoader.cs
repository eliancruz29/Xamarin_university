using MyTunes.Shared;
using System;
using System.IO;
using Windows.ApplicationModel;

namespace MyTunes.UWP
{
    public class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return Package.Current.InstalledLocation.GetFileAsync(filename)
                .AsTask().Result
                .OpenStreamForReadAsync().Result;
        }
    }
}
