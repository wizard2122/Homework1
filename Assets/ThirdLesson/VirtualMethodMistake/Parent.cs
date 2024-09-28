using UnityEngine;

public class Parent 
{
    public Parent(string onAddItemMessage)
    {
        AddNewItem(onAddItemMessage);
    }

    protected virtual void AddNewItem(string onAddItemMessage)
    {
        Debug.Log(onAddItemMessage);
    }
}
