// <copyright file="CloudOncePaths.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

public static class CloudOncePaths
{
    public const string Data = cloudOnce + "/Data";
    public const string Templates = cloudOnce + "/Internal/Data/Templates";
    public const string GoogleTemplates = cloudOnce + "/Internal/Editor/Utils/GooglePlayGamesSetup";
    public const string Android = plugins + "/Android";
    public const string GameCircleLib = Android + "/gamecircle_lib";
    public const string GooglePlayLib = Android + "/MainLibProj";
    public const string Settings = "ProjectSettings/CloudOnceSettings.txt";

    private const string cloudOnce = "Assets/Extensions/CloudOnce";
    private const string plugins = "Assets/Plugins";
}
