using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Transform _itemHolderPoint;
    [SerializeField] private ItemCollector _itemCollector;
    private ItemHandler _itemHandler;

    private void Awake()
    {
        Inventory inventory = new Inventory(_itemHolderPoint);

        _itemCollector.Initialize(inventory);
        _itemHandler = new ItemHandler(inventory, gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_itemHandler.CanUseItem())
            {
                _itemHandler.UseItem();
            }
        }
    }
}
