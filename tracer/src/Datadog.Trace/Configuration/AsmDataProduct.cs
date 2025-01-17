﻿// <copyright file="AsmDataProduct.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using Datadog.Trace.RemoteConfigurationManagement;

namespace Datadog.Trace.Configuration;

internal class AsmDataProduct : Product
{
    public override string Name => "ASM_DATA";
}
