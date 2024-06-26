﻿using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobManager.Mocks
{
    public interface IBlobServiceClient
    {
        IBlobContainerClient GetBlobContainerClient(string containerName);
    }
}
