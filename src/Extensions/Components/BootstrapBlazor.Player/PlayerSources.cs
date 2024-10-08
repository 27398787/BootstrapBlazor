﻿// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using System.Text.Json.Serialization;

namespace BootstrapBlazor.Components;

/// <summary>
/// PlayerSources 配置类
/// </summary>
public class PlayerSources
{
    /// <summary>
    /// 获得/设置 资源地址
    /// </summary>
    [JsonPropertyName("src")]
    public string? Url { get; set; }

    /// <summary>
    /// 获得/设置 资源类型
    /// </summary>
    public string? Type { get; set; } = "application/x-mpegURL";
}
