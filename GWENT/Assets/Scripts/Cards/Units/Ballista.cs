using UnityEngine;

public class Ballista : BaseStrengthCard, ISiegeWeapon
{
    private void Awake()
    {
        cardName = "��������";
        description = "������������ ������� ������";
        faction = Faction.NorthernRealms;
        strengthPoints = 6;
    }
}