using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private float _cooldown;

    [SerializeField] private int _minCoinValue;
    [SerializeField] private int _maxCoinValue;

    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _cooldown)
        {
            //Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

            List<SpawnPoint> emptyPoints = GetEmptyPoints();

            if(emptyPoints.Count == 0)
            {
                _time = 0;
                return;
            }

            SpawnPoint spawnPoint = emptyPoints[Random.Range(0, emptyPoints.Count)];

            Coin coin = Instantiate(_coinPrefab, spawnPoint.Position, Quaternion.identity, null);
            //coin.Initialize(Random.Range(_minCoinValue, _maxCoinValue));

            spawnPoint.Occypy(coin);

            _time = 0;
        }
    }

    private List<SpawnPoint> GetEmptyPoints()
    {
        List<SpawnPoint> emptyPoints = new List<SpawnPoint>();

        foreach (SpawnPoint spawnPoint in _spawnPoints)
            if(spawnPoint.IsEmpty)
                emptyPoints.Add(spawnPoint);

        return emptyPoints;
    }
} 
 