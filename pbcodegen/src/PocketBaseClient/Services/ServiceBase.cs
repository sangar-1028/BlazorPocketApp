﻿// Project site: https://github.com/iluvadev/PocketBaseClient-csharp
//
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// Copyright (c) 2022, iluvadev, and released under MIT License.
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

namespace PocketBaseClient.Services
{
    /// <summary>
    /// Base class for a Service
    /// </summary>
    public abstract class ServiceBase
    {
        internal PocketBaseClientApplication App { get; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="app"></param>
        public ServiceBase(PocketBaseClientApplication app)
        {
            App = app;
        }

    }
}
