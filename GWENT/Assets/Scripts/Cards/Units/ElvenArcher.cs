using UnityEngine;

public class ElvenArcher : BaseStrengthCard, IArcher
{
    private void Awake()
    {
        cardName = "Ёльфийский лучник";
        description = "ћеткий стрелок из эльфийского отр€да";
        faction = Faction.Scoiatael;
        strengthPoints = 4;
    }
}