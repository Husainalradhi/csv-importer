﻿using System.IO;
using System.Threading.Tasks;

namespace CsvImporter.Common.Utilities.Abstractions
{
    public interface ICloudBlockBlob
    {
        Task UploadFromStreamAsync(Stream stream);
        Task DownloadToStreamAsync(Stream stream);
        Task UploadTextAsync(string content);
    }
}