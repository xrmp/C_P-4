using System;
using System.Collections.Generic;
using UnityEngine;

public class CardObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class PoolConfig
    {
        public GameObject cardPrefab;
        public int initialPoolSize = 5;
    }

    [SerializeField] private List<PoolConfig> poolConfigs = new List<PoolConfig>();

    private readonly Dictionary<Type, Queue<Card>> _pool = new Dictionary<Type, Queue<Card>>();
    private readonly Dictionary<Type, GameObject> _prefabs = new Dictionary<Type, GameObject>();

    public static CardObjectPool Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializePool();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void InitializePool()
    {
        foreach (var config in poolConfigs)
        {
            if (config.cardPrefab != null)
            {
                var cardComponent = config.cardPrefab.GetComponent<Card>();
                if (cardComponent != null)
                {
                    var cardType = cardComponent.GetType();
                    _prefabs[cardType] = config.cardPrefab;
                    _pool[cardType] = new Queue<Card>();

                    Prewarm(cardType, config.initialPoolSize);
                }
            }
        }

        Debug.Log($"ObjectPool инициализирован. Типов карт: {_pool.Count}");
    }

    private void Prewarm(Type cardType, int count)
    {
        if (!_prefabs.ContainsKey(cardType)) return;

        for (int i = 0; i < count; i++)
        {
            var newCard = CreateNewCard(cardType);
            _pool[cardType].Enqueue(newCard);
            newCard.gameObject.SetActive(false);
        }
    }

    private Card CreateNewCard(Type cardType)
    {
        var prefab = _prefabs[cardType];
        var cardObject = Instantiate(prefab, transform);
        var card = cardObject.GetComponent<Card>();

        return card;
    }

    public T GetCard<T>() where T : Card
    {
        var type = typeof(T);

        if (!_pool.ContainsKey(type) || _pool[type].Count == 0)
        {
            if (_prefabs.ContainsKey(type))
            {
                Prewarm(type, 1);
            }
            else
            {
                Debug.LogError($"Prefab для типа {type} не зарегистрирован в ObjectPool!");
                return null;
            }
        }

        var card = _pool[type].Dequeue() as T;
        card.gameObject.SetActive(true);

        return card;
    }

    public void ReturnCard<T>(T card) where T : Card
    {
        var type = typeof(T);

        if (!_pool.ContainsKey(type))
        {
            _pool[type] = new Queue<Card>();
        }

        card.gameObject.SetActive(false);
        card.transform.SetParent(transform);
        _pool[type].Enqueue(card);
    }

    public void RegisterNewCardType(GameObject cardPrefab, int initialSize = 3)
    {
        var cardComponent = cardPrefab.GetComponent<Card>();
        if (cardComponent != null)
        {
            var cardType = cardComponent.GetType();
            _prefabs[cardType] = cardPrefab;
            _pool[cardType] = new Queue<Card>();
            Prewarm(cardType, initialSize);
        }
    }
}