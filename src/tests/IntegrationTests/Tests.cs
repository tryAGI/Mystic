namespace Mystic.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public MysticApi GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MYSTIC_API_KEY") ??
            throw new AssertInconclusiveException("MYSTIC_API_KEY environment variable is not found.");

        var api = new MysticApi(apiKey);
        
        return api;
    }
}
