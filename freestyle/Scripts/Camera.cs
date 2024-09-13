using Godot;
using System;

public partial class Camera : Node2D
{
	CharacterBody2D Player1;
	CharacterBody2D Player2;
	Camera2D Cam;
	Vector2 Player1pos;
	Vector2 Player2pos;
	
	public override void _Ready()
	{
		Player1 = GetNode<CharacterBody2D>("Players/Player");
		Player2 = GetNode<CharacterBody2D>("Players/Player2");
		Cam = GetNode<Camera2D>("Camera");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float CameraX = (Player1.Position.X + Player2.Position.X)/2;
		if(CameraX < 0){
		CameraX = 0;
		}
		//GD.Print("CamPos: "+ CameraX);
		Cam.Position = new Vector2(CameraX,0);
		if (Input.IsActionJustPressed("switch"))
		{
			Player1pos = Player1.Position;
			Player2pos = Player2.Position;
			Player1.Position = Player2pos;
			Player2.Position = Player1pos;
		}
	}
}
