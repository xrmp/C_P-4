public interface ISpecialAbility
{
    SpecialAbilityType AbilityType { get; }
    void ApplyAbility();
}

public interface IRareCard { }

public interface IUltimateCard
{
    void ApplyUltimate();
}

public interface IStrengthCard
{
    int StrengthPoints { get; }
    void ApplyStrength();
}

public interface IWeatherCard
{
    WeatherType WeatherType { get; }
    void ApplyWeatherEffect();
}