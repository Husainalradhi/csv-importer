﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CsvImporter.Common.Contracts.DTOs;

namespace CsvImporter.WebJob.CsvHandler.Abstractions
{
    public interface IAzureCloudStorageService
    {
        Task<MemoryStream> GetFileStream(JobDto item);
    }
}