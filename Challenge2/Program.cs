using Challenge2;

string metadataEndpoint = "http://{IPAddress}/metadata/instance?api-version=2021-02-01";

string accessToken = await AzureAccess.GetBearerTokenAsync();

string metadataJson = await AzureAccess.GetMetadataAsync(metadataEndpoint, accessToken);

Console.WriteLine(metadataJson);
