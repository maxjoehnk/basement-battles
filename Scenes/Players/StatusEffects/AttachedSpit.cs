public class AttachedSpit : StatusEffect
{
    public override string Name => "You got spit on.";
    
    public override float Duration => 5;

    public override void Apply(IPlayer player)
    {
        player.Speed *= 0.8f;
    }
}