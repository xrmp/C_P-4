using UnityEngine;

public class Fog : Card, IWeatherCard, IArcher
{
    private void Awake()
    {
        cardName = "����";
        description = "������������� ������ ���� �� ��� �������� ���";
        faction = Faction.Neutral;
    }

    public WeatherType WeatherType => WeatherType.Fog;

    public void ApplyWeatherEffect()
    {
        Debug.Log($"{cardName} ��������� �������� ������: ������������� ���� �� ��� �������� ���");
    }

    public override void ApplyCardActions()
    {
        ApplyWeatherEffect();
    }
}