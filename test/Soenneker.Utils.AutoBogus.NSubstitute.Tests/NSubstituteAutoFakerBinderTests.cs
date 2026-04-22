using Bogus;
using AwesomeAssertions;
using Soenneker.Tests.HostedUnit;
using Soenneker.Utils.AutoBogus.NSubstitute.Tests.Dtos;


namespace Soenneker.Utils.AutoBogus.NSubstitute.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class NSubstituteAutoFakerBinderTests : HostedUnitTest
{
    private readonly AutoFaker _faker;

    public NSubstituteAutoFakerBinderTests(Host host) : base(host)
    {
        _faker = new AutoFaker
        {
            Binder = new NSubstituteAutoFakerBinder()
        };
    }

    [Test]
    public void Should_Generate()
    {
        var result = _faker.Generate<TestClass>();
        result.Should().NotBeNull();
    }

    [Test]
    public void Should_Generate_Abstract()
    {
        var result = _faker.Generate<TestAbstractClass>();
        result.Should().NotBeNull();
    }
}
