using Bogus;
using AwesomeAssertions;
using Soenneker.Tests.FixturedUnit;
using Soenneker.Utils.AutoBogus.NSubstitute.Tests.Dtos;
using Xunit;


namespace Soenneker.Utils.AutoBogus.NSubstitute.Tests;

[Collection("Collection")]
public class NSubstituteAutoFakerBinderTests : FixturedUnitTest
{
    private readonly AutoFaker _faker;

    public NSubstituteAutoFakerBinderTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _faker = new AutoFaker
        {
            Binder = new NSubstituteAutoFakerBinder()
        };
    }

    [Fact]
    public void Should_Generate()
    {
        var result = _faker.Generate<TestClass>();
        result.Should().NotBeNull();
    }

    [Fact]
    public void Should_Generate_Abstract()
    {
        var result = _faker.Generate<TestAbstractClass>();
        result.Should().NotBeNull();
    }
}
