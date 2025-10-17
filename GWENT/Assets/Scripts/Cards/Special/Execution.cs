using UnityEngine;

public class Execution : Card, ISpecialAbility, IExecution
{
    private void Awake()
    {
        cardName = " азнь";
        description = "”ничтожает самую сильную карту противника на поле";
        faction = Faction.Nilfgaard;
    }

    public SpecialAbilityType AbilityType => SpecialAbilityType.Execution;

    public void ApplyAbility()
    {
        Debug.Log($"{cardName} примен€ет способность: ”ничтожает самую сильную карту противника");
    }

    public override void ApplyCardActions()
    {
        ApplyAbility();
    }
}