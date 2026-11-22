using System.Text.Json.Serialization;

namespace Rezads.Config;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DisplayType
{
    Chat,
    Center,
    CenterHtml,
    Screen
}