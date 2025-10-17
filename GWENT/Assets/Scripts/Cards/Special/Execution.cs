using UnityEngine;

public class Execution : Card, ISpecialAbility, IExecution
{
    private void Awake()
    {
        cardName = "�����";
        description = "���������� ����� ������� ����� ���������� �� ����";
        faction = Faction.Nilfgaard;
    }

    public SpecialAbilityType AbilityType => SpecialAbilityType.Execution;

    public void ApplyAbility()
    {
        Debug.Log($"{cardName} ��������� �����������: ���������� ����� ������� ����� ����������");
    }

    public override void ApplyCardActions()
    {
        ApplyAbility();
    }
}