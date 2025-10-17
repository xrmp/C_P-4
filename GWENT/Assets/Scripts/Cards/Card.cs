using UnityEngine;

public abstract class Card : MonoBehaviour
{
    [Header("Basic Card Info")]
    public string cardName;
    public Sprite icon;
    [TextArea(3, 5)]
    public string description;
    public Faction faction;

    public abstract void ApplyCardActions();

    public virtual string GetCardInfo()
    {
        var info = $"Создана карта {cardName}; ";

        // Определяем ряд размещения
        if (this is IMeleeFighter) info += "тип размещения: ближний бой; ";
        if (this is IArcher) info += "тип размещения: дальний бой; ";
        if (this is ISiegeWeapon) info += "тип размещения: осадное оружие; ";

        // Определяем специальные способности
        if (this is ISpy) info += "специальная способность: Шпион; ";
        if (this is IMedic) info += "специальная способность: Медик; ";
        if (this is IConnection) info += "специальная способность: Связь; ";
        if (this is IPretence) info += "специальная способность: Притворство; ";
        if (this is ITwin) info += "специальная способность: Близнецы; ";
        if (this is IStrengthSurge) info += "специальная способность: Прилив сил; ";
        if (this is IExecution) info += "специальная способность: Казнь; ";
        if (this is IBerserk) info += "специальная способность: Берсерк; ";
        if (this is IMardrem) info += "специальная способность: Мардрем; ";
        if (this is IAvengerCall) info += "специальная способность: Зов мстителя; ";

        // Добавляем очки силы
        if (this is IStrengthCard strengthCard)
        {
            info += $"очки силы: {strengthCard.StrengthPoints}; ";
        }

        // Добавляем информацию о погоде
        if (this is IWeatherCard weatherCard)
        {
            info += $"погодный эффект: {weatherCard.WeatherType}; ";
        }

        // Добавляем информацию о редкости
        if (this is IRareCard) info += "редкая карта; ";

        // Добавляем информацию об ульте
        if (this is IUltimateCard) info += "карта лидера; ";

        return info.TrimEnd(';', ' ');
    }

    protected virtual void Start()
    {
        Debug.Log(GetCardInfo());
    }
}