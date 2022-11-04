// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.Extensions.Logging;
using System;

namespace DataImport.Common.Preprocessors
{
    public class ProcessMessageEventArgs : EventArgs
    {
        public LogLevel Level { get; set; }
        public string Message { get; set; }
    }
}
