using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private ParticleSystem _useEffectPrefab;

    public abstract bool CanPickupFor(GameObject owner);

    public virtual void Use(GameObject owner)
    {
        Instantiate(_useEffectPrefab, owner.transform.position, Quaternion.identity, null);
    }
}
