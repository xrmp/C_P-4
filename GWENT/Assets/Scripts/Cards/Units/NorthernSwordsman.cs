using UnityEngine;

public class NorthernSwordsman : BaseStrengthCard, IMeleeFighter
{
    private void Awake()
    {
        cardName = "�������� ������";
        description = "������� ���� �������� ����������";
        faction = Faction.NorthernRealms;
        strengthPoints = 5;
    }
}