using Godot;
using System;

public partial class Player2 : CharacterBody2D
{
	public const float Speed = 100.0f;
	public const float JumpVelocity = -360.0f;
	AnimatedSprite2D player;
	
	public override void _Ready()
	{
		player = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}
	

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}

		// Handle Jump.
		if (Input.IsActionJustPressed("ui_hop") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
		}

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("ui_venstre", "ui_hojre", "ui_ned", "ui_up");
		
		if (direction.X > 0)
		{
			player.FlipH = false;
		}
		else if (direction.X < 0)
		{
			player.FlipH = true;
		}
		
		if (IsOnFloor())
		{
			if (direction.X == 0)
			{
				player.Play("Idle");
			}
			if (direction.X != 0)
			{
				player.Play("Run");
			}
		}
		else
		{
			player.Play("Jump");
		}
		
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}
		Velocity = velocity;
		MoveAndSlide();
	}
}
