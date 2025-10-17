using UnityEngine;

public class EmhyrWhiteFlame : BaseStrengthCard, IUltimateCard, IMeleeFighter
{
    private void Awake()
    {
        cardName = "Эмгыр вар Эмрейс Белое Пламя";
        description = "Император Нильфгаарда. Позволяет посмотреть 2 карты из колоды противника";
        faction = Faction.Nilfgaard;
        strengthPoints = 0;
    }

    public void ApplyUltimate()
    {
        Debug.Log($"{cardName} применяет ульту: Позволяет посмотреть 2 карты из колоды противника");
    }

    public override void ApplyCardActions()
    {
        ApplyUltimate();
    }

    public override void ApplyStrength()
    {
        // Лидеры не применяют очки силы
    }
}