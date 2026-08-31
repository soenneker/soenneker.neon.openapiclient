[![](https://img.shields.io/nuget/v/soenneker.neon.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.neon.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.neon.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.neon.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.neon.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.neon.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.neon.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.neon.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Neon.OpenApiClient

Typed request builders and models for calling the Neon management API from .NET.

## Installation

```bash
dotnet add package Soenneker.Neon.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Neon.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new NeonOpenApiClient(adapter);
var regions = await client.Regions.GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to `https://console.neon.tech/api/v2`. Set `adapter.BaseUrl` before constructing `NeonOpenApiClient` to use another endpoint.

For application registration, configuration-based credentials, and managed client reuse, use [`Soenneker.Neon.OpenApiClientUtil`](https://github.com/soenneker/soenneker.neon.openapiclientutil).
