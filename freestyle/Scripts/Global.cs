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
		//var level1 = load("Scene path")
		//var level2 = load("Scene path")
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
		if(level == 0)
		{
			//get_tree().change_scene_to_packed(level1)
			level = 1;
		}
		if(level == 1)
		{
			//get_tree().change_scene_to_packed(level2)
			level = 2;
		}
		P1Ready = false;
		P2Ready = false;
	}
	}
}
