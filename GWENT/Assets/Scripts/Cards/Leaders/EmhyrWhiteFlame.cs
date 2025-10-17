using UnityEngine;

public class EmhyrWhiteFlame : BaseStrengthCard, IUltimateCard, IMeleeFighter
{
    private void Awake()
    {
        cardName = "����� ��� ������ ����� �����";
        description = "��������� �����������. ��������� ���������� 2 ����� �� ������ ����������";
        faction = Faction.Nilfgaard;
        strengthPoints = 0;
    }

    public void ApplyUltimate()
    {
        Debug.Log($"{cardName} ��������� �����: ��������� ���������� 2 ����� �� ������ ����������");
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