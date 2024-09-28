using System.Collections.Generic;

public class Child : Parent
{
    private List<float> _list;

    public Child(string onAddItemMessage) : base(onAddItemMessage)
    {
        _list = new List<float>();
    }

    protected override void AddNewItem(string onAddItemMessage)
    {
        base.AddNewItem(onAddItemMessage);

        _list.Add(1f);
    }
}
