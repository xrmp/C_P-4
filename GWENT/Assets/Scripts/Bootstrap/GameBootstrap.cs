using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    [Header("Card Prefabs")]
    [SerializeField] private GameObject foltestPrefab;
    [SerializeField] private GameObject emhyrPrefab;
    [SerializeField] private GameObject commandersHornPrefab;
    [SerializeField] private GameObject executionPrefab;
    [SerializeField] private GameObject fogPrefab;
    [SerializeField] private GameObject ballistaPrefab;
    [SerializeField] private GameObject elvenArcherPrefab;
    [SerializeField] private GameObject northernSwordsmanPrefab;
    [SerializeField] private GameObject thalerPrefab;

    private void Awake()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        Debug.Log("=== ������������� ���� GWENT ===");

        // ObjectPool ������������� ���������������� ����� Awake()

        // ������� �������� ������ ����� ������������� ����
        Invoke(nameof(CreateTestDeck), 0.1f);
    }

    private void CreateTestDeck()
    {
        var cardPool = CardObjectPool.Instance;

        if (cardPool == null)
        {
            Debug.LogError("CardObjectPool �� ���������������!");
            return;
        }

        Debug.Log("\n=== �������� �������� ������ ===");

        // �������� ����� �� ����
        var foltest = cardPool.GetCard<FoltestNorthernLeader>();
        var emhyr = cardPool.GetCard<EmhyrWhiteFlame>();
        var commandersHorn = cardPool.GetCard<CommandersHorn>();
        var execution = cardPool.GetCard<Execution>();
        var fog = cardPool.GetCard<Fog>();
        var ballista = cardPool.GetCard<Ballista>();
        var elvenArcher = cardPool.GetCard<ElvenArcher>();
        var northernSwordsman = cardPool.GetCard<NorthernSwordsman>();
        var thaler = cardPool.GetCard<Thaler>();

        // �������� ������
        var deck = new Card[]
        {
            foltest, emhyr, commandersHorn, execution, fog,
            ballista, elvenArcher, northernSwordsman, thaler
        };

        Debug.Log($"\n������ �������! ����� ����: {deck.Length}");

        // ������������ ���������� �������� ����
        Debug.Log("\n=== ������������ �������� ���� ===");
        foreach (var card in deck)
        {
            card.ApplyCardActions();
        }

        // ���������� ����� � ���
        Debug.Log("\n=== ������� ���� � ��� ===");
        foreach (var card in deck)
        {
            cardPool.ReturnCard(card);
        }

        Debug.Log("��� ����� ���������� � ObjectPool");
    }
}