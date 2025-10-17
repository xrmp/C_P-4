using UnityEngine;

public class Fog : Card, IWeatherCard, IArcher
{
    private void Awake()
    {
        cardName = "Мгла";
        description = "Устанавливает погоду Мгла на ряд дальнего боя";
        faction = Faction.Neutral;
    }

    public WeatherType WeatherType => WeatherType.Fog;

    public void ApplyWeatherEffect()
    {
        Debug.Log($"{cardName} применяет погодный эффект: Устанавливает Мглу на ряд дальнего боя");
    }

    public override void ApplyCardActions()
    {
        ApplyWeatherEffect();
    }
}