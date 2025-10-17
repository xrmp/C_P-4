using UnityEngine;

public class CommandersHorn : Card, ISpecialAbility, IStrengthSurge
{
    private void Awake()
    {
        cardName = "��������� ���";
        description = "��������� ���� ���� ���� � ����";
        faction = Faction.NorthernRealms;
    }

    public SpecialAbilityType AbilityType => SpecialAbilityType.StrengthSurge;

    public void ApplyAbility()
    {
        Debug.Log($"{cardName} ��������� �����������: ��������� ���� ���� ���� � ��������� ����");
    }

    public override void ApplyCardActions()
    {
        ApplyAbility();
    }
}