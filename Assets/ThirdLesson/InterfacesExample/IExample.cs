using UnityEngine;

public interface IExample 
{
    int Property { get; }
    void Mehtod();
}

public interface IExample2
{
    void Method2();
}

public abstract class Example
{
    public abstract int Property { get; }

    public abstract void Mehtod();

    public virtual void Method2()
    {
        Debug.Log("asdasda");
    }
}

public class Test : MonoBehaviour, IExample2, IExample
{
    public int Property { get; }

    public void Mehtod()
    {
        Debug.Log("Method");

        Test test = new Test();
    }

    public void Method2()
    {
        throw new System.NotImplementedException();
    }
}