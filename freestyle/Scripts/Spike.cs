using Godot;
using System;

public partial class Spike : Area2D
{
	
	Timer DeathTimer;
	AnimatedSprite2D Nspike;
	AudioStreamPlayer2D Death;
	bool dead = false;
	
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
	
	private void _OnBodyEntered(Node2D other)
	{
		
			// Chick if collisino comes from Player
			
			// other ??
			GD.Print("Spike collision from: "+ other );
			if ( other.Name == "Player"  || other.Name == "Player2") 
			{
				if(dead == false)
				{
					dead = true;
					DeathTimer.Start();
					Nspike.Play("death");
					Death.Play();
					if (other.Name == "Player")
					{
						GetNode<CharacterBody2D>("/root/Level0/Players/Player").SetPhysicsProcess(false);
					}
					if (other.Name == "Player2")
					{
						GetNode<CharacterBody2D>("/root/Level0/Players/Player2").SetPhysicsProcess(false);
					}
				}
			}
	}
	
	private void _OnDeathTimer(){
		GetTree().ReloadCurrentScene();
		dead = false;
		GetNode<CharacterBody2D>("/root/Level0/Players/Player").SetPhysicsProcess(true);
		GetNode<CharacterBody2D>("/root/Level0/Players/Player2").SetPhysicsProcess(true);
	}
	
}
