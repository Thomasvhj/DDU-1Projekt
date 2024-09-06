using Godot;
using System;

public partial class Door1 : Area2D
{
	bool Player1OnDoor;

		private void _OnBodyEntered(Node2D other)
		{
			Player1OnDoor = true;
		}
		
			public override void _Process(double delta)
			{
				if(Input.IsActionJustPressed("ui_down") && Player1OnDoor == true)
				{
					GetNode<Global>("/root/Global").P1Ready = true;
					GetNode<Global>("/root/Global").SwitchLevel();
				}
			}
		
		private void _OnBodyExited(Node2D other)
		{
			Player1OnDoor = false;
				GetNode<Global>("/root/Global").P1Ready = false;
		}
}
