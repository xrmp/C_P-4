using UnityEngine;

public class FoltestNorthernLeader : BaseStrengthCard, IUltimateCard, IMeleeFighter
{
    private void Awake()
    {
        cardName = "Фольтест Предводитель Севера";
        description = "Лидер Северных Королевств. Увеличивает силу всех осадных орудий на 1";
        faction = Faction.NorthernRealms;
        strengthPoints = 0; // Лидеры не имеют очков силы
    }

    public void ApplyUltimate()
    {
        Debug.Log($"{cardName} применяет ульту: Увеличивает силу всех осадных орудий на 1");
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