using Godot;
using System;

public partial class Spike : Area2D
{
	
	Timer DeathTimer;
	AnimatedSprite2D Nspike;
	AudioStreamPlayer2D Death;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		DeathTimer = GetNode<Timer>("DeathTimer");
		Nspike = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		Death = GetNode<AudioStreamPlayer2D>("DeathSound");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		
	}
	
	private void _OnBodyEntered(Node2D other){
			DeathTimer.Start();
			Nspike.Play("death");
			Death.Play();
		}
	
	private void _OnDeathTimer(){
		GetTree().ReloadCurrentScene();
	}
	
}
