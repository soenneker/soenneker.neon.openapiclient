using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Neon.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class NeonOpenApiClientTests : FixturedUnitTest
{
    public NeonOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
