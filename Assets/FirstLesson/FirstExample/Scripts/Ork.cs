using UnityEngine;

public abstract class Ork 
{
    public Ork(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public virtual bool IsAlive => Health > 0;
    public string Name { get; }
    public virtual int Health { get; protected set;}
    public int Damage { get; protected set;}

    public virtual void TakeDamage(int damage)
    {
        Debug.Log("Любой орк получил урон");

        if(damage < 0)
        {
            Debug.LogError("damage < 0");
            return;
        }

        Health -= damage;

        if(Health <= 0)
        {
            Health = 0;
            Debug.Log($"О нет, я умер");
        }
    }

    public abstract void IssueCry();
}

