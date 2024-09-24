using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int Coins { get; private set; }

    public void Add(Coin coin)
    {
        Coins += coin.GetValue();

        Debug.Log($"Монет собрано: {Coins}");
    }
}
