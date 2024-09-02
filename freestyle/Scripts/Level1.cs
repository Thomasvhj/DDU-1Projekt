using Godot;
using System;

public partial class Level1 : Node2D
{
	CharacterBody2D Player1;
	CharacterBody2D Player2;
	Camera2D Camera;
	Vector2 Player1pos;
	Vector2 Player2pos;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Player1 = GetNode<CharacterBody2D>("Player");
		Player2 = GetNode<CharacterBody2D>("Player2");
		Camera = GetNode<Camera2D>("Camera");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float CameraX = (Player1.Position.X + Player2.Position.X)/2;
		if(CameraX < 0){
			CameraX = 0;
		}
		GD.Print("CamPos: "+ CameraX);
		Camera.Position = new Vector2(CameraX,0);
			if (Input.IsActionJustPressed("switch"))
			{
				Player1pos = Player1.Position;
				Player2pos = Player2.Position;
				Player1.Position = Player2pos;
				Player2.Position = Player1pos;
			}
			
	}
}
