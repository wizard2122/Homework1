using UnityEngine;

public class ItemHandler
{
    private Inventory _inventory;
    private GameObject _owner;

    public ItemHandler(Inventory inventory, GameObject gameObject)
    {
        _inventory = inventory;
        _owner = gameObject;
    }

    public bool CanUseItem() => _inventory.HasItem();

    public void UseItem()
    {
        if(CanUseItem() == false)
        {
            Debug.LogError("������ ������������ �������");
            return;
        }

        Item item = _inventory.GetItem();
        item.Use(_owner);
        Object.Destroy(item.gameObject);
    }
}
