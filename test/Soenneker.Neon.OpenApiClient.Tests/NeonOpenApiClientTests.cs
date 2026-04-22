using Soenneker.Tests.HostedUnit;

namespace Soenneker.Neon.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NeonOpenApiClientTests : HostedUnitTest
{
    public NeonOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
