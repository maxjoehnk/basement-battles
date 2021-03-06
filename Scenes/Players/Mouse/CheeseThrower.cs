using Godot;

public class CheeseThrower : Position2D
{
    private const float Velocity = 2500.0f;
    
    private PackedScene Cheese;
    
    public Timer Cooldown => GetNode<Timer>("Cooldown");

    public override void _Ready()
    {
        this.Cheese = (PackedScene)ResourceLoader.Load("res://Scenes/Players/Mouse/Cheese.tscn");
    }

    public void Throw(Vector2 direction)
    {
        if (!Cooldown.IsStopped())
        {
            return;
        }

        RigidBody2D cheese = (RigidBody2D)this.Cheese.Instance();
        cheese.GlobalPosition = GlobalPosition;
        cheese.LinearVelocity = new Vector2(direction.x * Velocity, direction.y * Velocity);
        cheese.SetAsToplevel(true);
        AddChild(cheese);
        Cooldown.Start();
    }
}
