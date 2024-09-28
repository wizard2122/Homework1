using UnityEngine;

public class Health 
{
    public Health(int value)
    {
        Value = value;
    }

    public int Value { get; private set; }

    public virtual void Reduce(int value)
    {
        if (value < 0)
        {
            Debug.LogError("value < 0");
            return;
        }

        Value -= value;

        if (Value < 0)
        {
            Value = 0;
            Debug.Log("ъ слеп!");
        }

        Debug.Log(Value);
    }
}
