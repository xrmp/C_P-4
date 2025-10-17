using UnityEngine;

public class Thaler : BaseStrengthCard, IMeleeFighter, ISpy, IRareCard
{
    private void Awake()
    {
        cardName = "Талер";
        description = "Шпион Северных Королевств";
        faction = Faction.NorthernRealms;
        strengthPoints = 0;
    }

    public override void ApplyStrength()
    {
        Debug.Log($"{cardName} - шпион, размещается на стороне противника");
    }
}