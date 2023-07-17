using Azure.Core;
using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public static class AzureAccess
    {
        public static async Task<string> GetBearerTokenAsync()
        {
            var credential = new DefaultAzureCredential();

            var tokenRequestContext = new TokenRequestContext(new[] { "https://management.azure.com/.default" });

            var token = await credential.GetTokenAsync(tokenRequestContext);

            return token.Token;
        }

        public static async Task<string> GetMetadataAsync(string metadataEndpoint, string accessToken)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Metadata", "true");
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

                var response = await httpClient.GetAsync(metadataEndpoint);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception($"Failed to retrieve metadata. Status code: {response.StatusCode}");
                }
            }
        }


    }

}
