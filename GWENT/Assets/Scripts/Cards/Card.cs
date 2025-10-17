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
        var info = $"������� ����� {cardName}; ";

        // ���������� ��� ����������
        if (this is IMeleeFighter) info += "��� ����������: ������� ���; ";
        if (this is IArcher) info += "��� ����������: ������� ���; ";
        if (this is ISiegeWeapon) info += "��� ����������: ������� ������; ";

        // ���������� ����������� �����������
        if (this is ISpy) info += "����������� �����������: �����; ";
        if (this is IMedic) info += "����������� �����������: �����; ";
        if (this is IConnection) info += "����������� �����������: �����; ";
        if (this is IPretence) info += "����������� �����������: �����������; ";
        if (this is ITwin) info += "����������� �����������: ��������; ";
        if (this is IStrengthSurge) info += "����������� �����������: ������ ���; ";
        if (this is IExecution) info += "����������� �����������: �����; ";
        if (this is IBerserk) info += "����������� �����������: �������; ";
        if (this is IMardrem) info += "����������� �����������: �������; ";
        if (this is IAvengerCall) info += "����������� �����������: ��� ��������; ";

        // ��������� ���� ����
        if (this is IStrengthCard strengthCard)
        {
            info += $"���� ����: {strengthCard.StrengthPoints}; ";
        }

        // ��������� ���������� � ������
        if (this is IWeatherCard weatherCard)
        {
            info += $"�������� ������: {weatherCard.WeatherType}; ";
        }

        // ��������� ���������� � ��������
        if (this is IRareCard) info += "������ �����; ";

        // ��������� ���������� �� �����
        if (this is IUltimateCard) info += "����� ������; ";

        return info.TrimEnd(';', ' ');
    }

    protected virtual void Start()
    {
        Debug.Log(GetCardInfo());
    }
}