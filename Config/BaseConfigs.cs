using CounterStrikeSharp.API.Core;
using System.Text.Json.Serialization;
using Rezads.Config.Models;

namespace Rezads.Config;

public class BaseConfigs : BasePluginConfig
{
    [JsonPropertyName("ChatPrefix")]
    public string ChatPrefix { get; set; } = "[{ORANGE}Rez{RED}Top{YELLOW}.cc{WHITE}]";

    [JsonPropertyName("GlobalPlaySound")]
    public string? GlobalPlaySound { get; set; } = "ui/panorama/popup_reveal_01";

    [JsonPropertyName("GlobalInterval")]
    public float GlobalInterval { get; set; } = 30f;

    [JsonPropertyName("GlobalPositionX")]
    public float GlobalPositionX { get; set; } = -1.5f;

    [JsonPropertyName("GlobalPositionY")]
    public float GlobalPositionY { get; set; } = 1f;

    [JsonPropertyName("AdminFlag")]
    public string? AdminFlag { get; set; } = "@css/generic";

    [JsonPropertyName("SendAdsInOrder")]
    public bool SendAdsInOrder { get; set; } = true;

    [JsonPropertyName("UseWelcomeMessage")]
    public bool EnableWelcomeMessage { get; set; } = true;

    [JsonPropertyName("JoinLeaveMessages")]
    public bool EnableJoinLeaveMessages { get; set; } = true;

    [JsonPropertyName("JoinLeaveExcludedNames")]
    public List<string> JoinLeaveExcludedNames { get; set; } = new()
    {
        "hvh.gg",
        "hvh.dog"
    };

    [JsonPropertyName("SpecialJoinMessages")]
    public List<SpecialJoinConfig> SpecialJoinMessages { get; set; } = new()
    {
        new SpecialJoinConfig
        {
            SteamID = 76561198701295193,
            Message = "{prefix} {GREEN}{playername} {RED}Разработчик {WHITE}присоединился к игре!!"
        },
        new SpecialJoinConfig
        {
            SteamID = 76561198375393174,
            Message = "{prefix} {ORANGE}{playername} {BLUE}Beta-Тестер {WHITE}присоединился к игре!!"
        }
    };

    [JsonPropertyName("WelcomeDelay")]
    public float WelcomeDelay { get; set; } = 3f;

    [JsonPropertyName("CenterHtmlDisplayTime")]
    public float centerHtmlDisplayTime { get; set; } = 5f;

    [JsonPropertyName("ScreenDisplayTime")]
    public float ScreenDisplayTime { get; set; } = 5f;

    [JsonPropertyName("UseMultiLang")]
    public bool UseMultiLang { get; set; } = true;

    [JsonPropertyName("DefaultLanguage")]
    public string DefaultLanguage { get; set; } = "ru";

    [JsonPropertyName("Welcome")]
    public List<WelcomeConfig> Welcome { get; set; } = new()
    {
        new WelcomeConfig
        {
            WelcomeMessage = "{prefix} {WHITE}Добро пожаловать {ORANGE}{playername}!",
            ViewFlag = "all",
            ExcludeFlag = ""
        }
    };

    [JsonPropertyName("JoinLeave")]
    public List<JoinLeaveConfig> JoinLeave { get; set; } = new()
    {
        new JoinLeaveConfig
        {
            JoinMessage = "{prefix} {GREEN}{playername} ({id64}) {WHITE}Присоединился к игре {RED}Online: {WHITE}{players}/{maxplayers}.",
            LeaveMessage = "{prefix} {RED}{playername} ({id64}) {WHITE}Покинул игру!"
        }
    };

    [JsonPropertyName("Ads")]
    public List<AdConfig> Ads { get; set; } = new()
    {
        new AdConfig
        {
            Message = "{prefix} {WHITE}На сервере отключён - {RED}Duble Tap",
            ViewFlag = "all",
            Map = "all"
        },
        new AdConfig
        {
            Message = "{prefix} {WHITE}Магазин проекта - {GREEN}RezTop.cc",
            ViewFlag = "all",
            Map = "all",
            DisableSound = true,
            DisableOrder = true
        },
        new AdConfig
        {
            Message = "{prefix} {WHITE}Наш сайт - {GREEN}RezTop.cc",
            ViewFlag = "all",
            Map = "all",
            DisableSound = true,
            DisableOrder = true
        }
    };
}
