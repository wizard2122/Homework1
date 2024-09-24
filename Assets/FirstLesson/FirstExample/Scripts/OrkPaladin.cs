using UnityEngine;

public class OrkPaladin : Ork
{
    private int _healAmount;

    private int _armor;

    public OrkPaladin(string name, int health, int damage, int healAmount, int armor) : base(name, health, damage)
    {
        _healAmount = healAmount;
        _armor = armor; 
    }

    public override bool IsAlive => base.IsAlive || _armor > 0;

    public void Heal()
    {
        Debug.Log("ß èñïîëüçóş ëå÷åíèå");
        Health += _healAmount;
    }

    public override void IssueCry()
    {
        Debug.Log("ÎĞÊ ÏÀËÀÄÈÍ ÈÇÄÀÅÒ ÊËÈ×");
    }

    public override void TakeDamage(int damage)
    {
        damage -= _armor;

        if(damage < 0)
            damage = 0;

        base.TakeDamage(damage);
    }
}
