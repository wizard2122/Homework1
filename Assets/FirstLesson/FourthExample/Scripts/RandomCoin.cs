using UnityEngine;

public class RandomCoin : Coin
{
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;

    public override int GetValue() => Random.Range(_minValue, _maxValue);
}
