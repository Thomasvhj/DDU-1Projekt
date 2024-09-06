using Godot;
using System;

public partial class Coin : Area2D
{
		AnimatedSprite2D coin;

	public override void _Ready()
	{
		coin = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}
	public void _OnBodyEntered(Node2D other)
	{
		coin.Play("Pickup");
		GetNode<CollisionShape2D>("CollisionShape2D").QueueFree();
		GetNode<Global>("/root/Global").ScoreAdd( 1 );
	}
	
	public void _OnAnimationEnd()
	{
		QueueFree();
	}
}
