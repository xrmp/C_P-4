using UnityEngine;

public class CommandersHorn : Card, ISpecialAbility, IStrengthSurge
{
    private void Awake()
    {
        cardName = "Командный рог";
        description = "Удваивает силу всех карт в ряду";
        faction = Faction.NorthernRealms;
    }

    public SpecialAbilityType AbilityType => SpecialAbilityType.StrengthSurge;

    public void ApplyAbility()
    {
        Debug.Log($"{cardName} применяет способность: Удваивает силу всех карт в выбранном ряду");
    }

    public override void ApplyCardActions()
    {
        ApplyAbility();
    }
}