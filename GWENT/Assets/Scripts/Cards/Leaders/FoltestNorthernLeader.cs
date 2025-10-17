using UnityEngine;

public class FoltestNorthernLeader : BaseStrengthCard, IUltimateCard, IMeleeFighter
{
    private void Awake()
    {
        cardName = "�������� ������������ ������";
        description = "����� �������� ����������. ����������� ���� ���� ������� ������ �� 1";
        faction = Faction.NorthernRealms;
        strengthPoints = 0; // ������ �� ����� ����� ����
    }

    public void ApplyUltimate()
    {
        Debug.Log($"{cardName} ��������� �����: ����������� ���� ���� ������� ������ �� 1");
    }

    public override void ApplyCardActions()
    {
        ApplyUltimate();
    }

    public override void ApplyStrength()
    {
        // ������ �� ��������� ���� ����
    }
}