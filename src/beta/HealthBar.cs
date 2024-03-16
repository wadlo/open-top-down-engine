using Godot;
using System;

public partial class HealthBar : Node2D
{
    [Export]
    Health health;

    [Export]
    ProgressBar healthProgressBar;

    private float startingHealth;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        startingHealth = health.health;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        if (health.health < startingHealth)
        {
            Visible = true;
            healthProgressBar.Value = health.health / startingHealth * 100.0f;
        }
        else
        {
            Visible = false;
        }
    }
}
