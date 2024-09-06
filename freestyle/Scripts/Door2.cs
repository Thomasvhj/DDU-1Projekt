using Godot;
using System;

public partial class Door2 : Area2D
{
	bool Player2OnDoor;

		private void _OnBodyEntered(Node2D other)
		{
			Player2OnDoor = true;
		}
		
			public override void _Process(double delta)
			{
				if(Input.IsActionJustPressed("ui_ned") && Player2OnDoor == true)
				{
					GetNode<Global>("/root/Global").P2Ready = true;
					GetNode<Global>("/root/Global").SwitchLevel();
				}
			}
		
		private void _OnBodyExited(Node2D other)
		{
			Player2OnDoor = false;
			GetNode<Global>("/root/Global").P2Ready = false;
		}
}
