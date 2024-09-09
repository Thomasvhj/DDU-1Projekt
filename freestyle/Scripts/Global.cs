using Godot;
using System;


public partial class Global : Node
{
	int level = 0;
	public bool P1Ready = false;
	public bool P2Ready = false;
	[Signal]
	public delegate void ScoreChangedEventHandler(string score);
	
	public int score = 0;
	
	public override void _Ready()
	{
	}
	
	public void ScoreAdd(int antal)
	{
		this.score += antal;
		EmitSignal(SignalName.ScoreChanged, this.score);
	}

	public void SwitchLevel()
	{
		if(P1Ready == true && P2Ready == true)
		{
			if(score == 6){
				if(level == 0)
				{
					//GetTree().Root.AddChild(ResourceLoader.Load<PackedScene>("res://Scenes/Level1.tscn").Instantiate());
					//GetTree().Root.RemoveChild(ResourceLoader.Load<PacketScene>("res://Scenes/LevelBP.tscn").Instantiate());
					level = 1;
				}
				if(level == 1)
				{
					//GetTree().Root.AddChild(ResourceLoader.Load<PackedScene>("res://Scenes/Level2.tscn").Instantiate());
					//GetTree().Root.RemoveChild(ResourceLoader.Load<PacketScene>("res://Scenes/Level1.tscn").Instantiate());
					level = 2;
				}
			P1Ready = false;
			P2Ready = false;
			score = 0;
			}
		}
	}
}
