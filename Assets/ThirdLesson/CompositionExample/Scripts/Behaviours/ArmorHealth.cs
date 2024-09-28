public class ArmorHealth : Health
{
    private int _armor;

    public ArmorHealth(int value, int armor) : base(value)
    {
        _armor = armor;
    }

    public override void Reduce(int value)
    {
        value -= _armor;

        if (value < 0)
            value = 0;

        base.Reduce(value);
    }
}
