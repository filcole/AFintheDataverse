using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Xrm.Tooling.Connector;

namespace ss.CrmServiceClientOpenAPI
{
    class CrmClientOverrideAuthHookWrapper: IOverrideAuthHookWrapper
    {
        private readonly AzureServiceTokenProvider azureServiceTokenProvider;

        public CrmClientOverrideAuthHookWrapper(AzureServiceTokenProvider tokenProvider)
        {
            azureServiceTokenProvider = tokenProvider;
        }

        // The Uri passed in here is the Dataverse URL, i.e.
        // https://ss2021pc.crm11.dynamics.com/XRMServices/2011/Organization.svc/web?SDKClientVersion=9.0.39
        public string GetAuthToken(Uri connectedUri)
        {
            // extract the org URL to just get the hostname
            var orgUrl = connectedUri.GetComponents(UriComponents.SchemeAndServer, UriFormat.UriEscaped);

            // The access token is cached.
            // Token expires after approx 5 minutes.
            var accessToken = azureServiceTokenProvider.GetAccessTokenAsync(orgUrl).Result;

            return accessToken;
        }
    }
}
