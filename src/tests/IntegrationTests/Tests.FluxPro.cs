namespace Mystic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FluxPro()
    {
        using var api = GetAuthenticatedApi();

        var result = await api.Runs.SubmitRunV4RunsPostAsync(
            pipeline: "black-forest-labs/flux-pro:v1",
            inputs: new List<RunInput>
            {
                new()
                {
                    Type = RunIOType.Dictionary,
                    Value = new RunInputValue
                    {
                        AdditionalProperties = new Dictionary<string, object>
                        {
                            ["prompt"] = "a female, european, young adult, fit body, wavy acid orange hair, wearing open swimsuit, sea in the background.",
                            ["width"] = 1024,
                            ["height"] = 1024,
                            ["variant"] = "flux.1-pro",
                            ["steps"] = 25,
                            ["prompt_upsampling"] = false,
                            ["seed"] = Random.Shared.Next(0, 1000000),
                            ["guidance"] = 3.5,
                            ["safety_tolerance"] = 5,
                            ["interval"] = 3,
                        }
                    },
                },
            }
        );

        Console.WriteLine($"Output: {new Uri(result.Outputs![0].File!.Url!)}");
        
        result.Outputs.Should().NotBeNull();
        result.Outputs.Should().HaveCount(1);
        result.Outputs![0].File.Should().NotBeNull();
        result.Outputs![0].File!.Url.Should().NotBeNullOrEmpty();
    }
}
