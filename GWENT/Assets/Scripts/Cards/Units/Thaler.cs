using UnityEngine;

public class Thaler : BaseStrengthCard, IMeleeFighter, ISpy, IRareCard
{
    private void Awake()
    {
        cardName = "�����";
        description = "����� �������� ����������";
        faction = Faction.NorthernRealms;
        strengthPoints = 0;
    }

    public override void ApplyStrength()
    {
        Debug.Log($"{cardName} - �����, ����������� �� ������� ����������");
    }
}