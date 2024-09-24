using UnityEngine;

public class StandardCoin : Coin
{
    [SerializeField] private int _value;

    public override int GetValue() => _value;
}
