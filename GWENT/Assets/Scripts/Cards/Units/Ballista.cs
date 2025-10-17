using UnityEngine;

public class Ballista : BaseStrengthCard, ISiegeWeapon
{
    private void Awake()
    {
        cardName = "Баллиста";
        description = "Дальнобойное осадное оружие";
        faction = Faction.NorthernRealms;
        strengthPoints = 6;
    }
}