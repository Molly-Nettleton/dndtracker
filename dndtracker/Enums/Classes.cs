using System.Text.Json.Serialization;
namespace dndtracker.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Classes
{
  barbarian, bard, cleric, druid, fighter, monk, paladin, ranger, rogue, sorcerer, warlock, wizard
}
