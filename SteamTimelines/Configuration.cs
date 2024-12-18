﻿using System;
using Dalamud.Configuration;
using Newtonsoft.Json;

namespace SteamTimelines;

[Serializable]
public class Configuration : IPluginConfiguration {
    public int Version { get; set; } = 0;

    [JsonProperty] public uint? NonSteamAppId;

    public void Save() {
        Services.PluginInterface.SavePluginConfig(this);
    }
}
