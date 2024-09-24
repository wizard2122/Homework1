using UnityEngine;

public abstract class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CoinCollector collector = other.GetComponent<CoinCollector>();

        if(collector != null)
        {
            collector.Add(this);
            Destroy(gameObject);
        }
    }

    public abstract int GetValue();
}
