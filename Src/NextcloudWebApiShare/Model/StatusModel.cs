namespace NextcloudWebApi.Model;

internal class StatusModel
{
    [JsonPropertyName("installed")]
    public bool Installed { get; set; }

    [JsonPropertyName("maintenance")]
    public bool Maintenance { get; set; }

    [JsonPropertyName("needsDbUpgrade")]
    public bool NeedsDbUpgrade { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; } = null!;

    [JsonPropertyName("versionstring")]
    public string VersionString { get; set; } = null!;

    [JsonPropertyName("edition")]
    public string Edition { get; set; } = null!;

    [JsonPropertyName("productname")]
    public string ProductName { get; set; } = null!;

    [JsonPropertyName("extendedSupport")]
    public bool ExtendedSupport { get; set; }
}
