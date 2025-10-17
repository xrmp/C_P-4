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
        Debug.Log("=== ИНИЦИАЛИЗАЦИЯ ИГРЫ GWENT ===");

        // ObjectPool автоматически инициализируется через Awake()

        // Создаем тестовую колоду после инициализации пула
        Invoke(nameof(CreateTestDeck), 0.1f);
    }

    private void CreateTestDeck()
    {
        var cardPool = CardObjectPool.Instance;

        if (cardPool == null)
        {
            Debug.LogError("CardObjectPool не инициализирован!");
            return;
        }

        Debug.Log("\n=== СОЗДАНИЕ ТЕСТОВОЙ КОЛОДЫ ===");

        // Получаем карты из пула
        var foltest = cardPool.GetCard<FoltestNorthernLeader>();
        var emhyr = cardPool.GetCard<EmhyrWhiteFlame>();
        var commandersHorn = cardPool.GetCard<CommandersHorn>();
        var execution = cardPool.GetCard<Execution>();
        var fog = cardPool.GetCard<Fog>();
        var ballista = cardPool.GetCard<Ballista>();
        var elvenArcher = cardPool.GetCard<ElvenArcher>();
        var northernSwordsman = cardPool.GetCard<NorthernSwordsman>();
        var thaler = cardPool.GetCard<Thaler>();

        // Собираем колоду
        var deck = new Card[]
        {
            foltest, emhyr, commandersHorn, execution, fog,
            ballista, elvenArcher, northernSwordsman, thaler
        };

        Debug.Log($"\nКолода создана! Всего карт: {deck.Length}");

        // Демонстрация применения действий карт
        Debug.Log("\n=== ДЕМОНСТРАЦИЯ ДЕЙСТВИЙ КАРТ ===");
        foreach (var card in deck)
        {
            card.ApplyCardActions();
        }

        // Возвращаем карты в пул
        Debug.Log("\n=== ВОЗВРАТ КАРТ В ПУЛ ===");
        foreach (var card in deck)
        {
            cardPool.ReturnCard(card);
        }

        Debug.Log("Все карты возвращены в ObjectPool");
    }
}