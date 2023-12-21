using Microsoft.SemanticKernel;
using Plugins;

var (apiKey, orgId) = Settings.LoadFromFile();

// Create kernel
var builder = Kernel.CreateBuilder();
builder.Plugins.AddFromType<Dalle3>();
var kernel = builder.Build();

// Test the math plugin
string answer = await kernel.InvokeAsync<string>(
"Dalle3", "ImageFromPrompt",
    new() {
        { "prompt", "cat" }
    }
);

Console.Write(answer);
