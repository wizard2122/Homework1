public class AgilityHealth : Health
{
    private int _agility;

    public AgilityHealth(int value, int agility) : base(value)
    {
        _agility = agility;
    }

    public override void Reduce(int value)
    {
        value /= _agility;

        base.Reduce(value);
    }
}
