using UnityEngine;

public class NorthernSwordsman : BaseStrengthCard, IMeleeFighter
{
    private void Awake()
    {
        cardName = "Северный мечник";
        description = "Опытный воин Северных Королевств";
        faction = Faction.NorthernRealms;
        strengthPoints = 5;
    }
}