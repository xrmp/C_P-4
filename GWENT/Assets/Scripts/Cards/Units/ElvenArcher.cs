using UnityEngine;

public class ElvenArcher : BaseStrengthCard, IArcher
{
    private void Awake()
    {
        cardName = "���������� ������";
        description = "������ ������� �� ����������� ������";
        faction = Faction.Scoiatael;
        strengthPoints = 4;
    }
}