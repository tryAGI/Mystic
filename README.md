# Mystic

[![Nuget package](https://img.shields.io/nuget/vpre/Mystic)](https://www.nuget.org/packages/Mystic/)
[![dotnet](https://github.com/tryAGI/Mystic/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Mystic/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Mystic)](https://github.com/tryAGI/Mystic/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Mystic OpenAPI specification](https://raw.githubusercontent.com/Mystic/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Mystic;

using var api = new MysticApi(apiKey);

var result = await api.Runs.SubmitRunAsync(
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
```

## Support

Priority place for bugs: https://github.com/tryAGI/Mystic/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Mystic/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).