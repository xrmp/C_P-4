using UnityEngine;

public abstract class BaseStrengthCard : Card, IStrengthCard
{
    [Header("Strength Settings")]
    [SerializeField] protected int strengthPoints = 1;

    public int StrengthPoints => strengthPoints;

    public virtual void ApplyStrength()
    {
        Debug.Log($"{cardName} применяет очки силы: {strengthPoints}");
    }

    public override void ApplyCardActions()
    {
        ApplyStrength();
    }
}