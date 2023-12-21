# A DALL-E 3 C# Plugin for Semantic Kernel v1.0.1

This plugin uses the OpenAI REST API to submit a prompt to the DALL-E 3 model and return the resulting URL.

To use this plugin, you must have an OpenAI API key.

## Setting up the configuration key

The configuration key is a JSON file that contains your OpenAI API key. To set it up, create a file called `settings.json` in the `config` directory. The `orgId` is not used.

```json
{
    "apiKey": "<your API key here>",
    "orgId": "<your organization ID here>"
}
```

## Calling the plugin with Semantic Kernel 1.0.1

Using the plugin is straightforward. With the plugin in your code directory, you can call it like this:

```csharp
using Microsoft.SemanticKernel;
using Plugins;

var (apiKey, orgId) = Settings.LoadFromFile();

var builder = Kernel.CreateBuilder();
builder.Plugins.AddFromType<Dalle3>();
var kernel = builder.Build();

string prompt = "A cat sitting on a couch in the style of Monet"; 
string? url = await kernel.InvokeAsync<string>(
    "Dalle3", "ImageFromPrompt", new() {{ "prompt", prompt }}
);

Console.Write(url);
```
## Sample image generated with the plugin

![A cat sitting on a couch in the style of Monet](cat_impressionist.png)