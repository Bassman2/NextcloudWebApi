using System.Xml;
using System.Xml.XPath;

namespace NextcloudWebApi;

// https://docs.nextcloud.com/server/22/developer_manual/client_apis/OCS/ocs-api-overview.html#capabilities-api

public class Nextcloud : JsonService
{
    public Nextcloud(string storeKey, string appName) : base(storeKey, appName, SourceGenerationContext.Default)
    { }

    public Nextcloud(Uri host, IAuthenticator? authenticator, string appName) : base(host, authenticator, appName, SourceGenerationContext.Default)
    { }

    //protected override string? AuthenticationTestUrl => "api/health";


    public override async Task<string?> GetVersionStringAsync(CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNotConnected(client);

        // https://nc.elektrobit.com/status.php

        var res = await GetFromJsonAsync<StatusModel>("status.php", cancellationToken);

       
        return res?.VersionString ?? "0.0.0";
    }

    public async Task<Health?> GetHealthAsync(CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNotConnected(client);

        var res = await GetFromJsonAsync<HealthModel>("api/health", cancellationToken);
        return res.CastModel<Health>();
    }
}
