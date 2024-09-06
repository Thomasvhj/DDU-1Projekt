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
	//simultaneousScene1 = ResourceLoader.Load<PackedScene>("res://levels/level1.tscn").Instantiate();
	//simultaneousScene2 = ResourceLoader.Load<PackedScene>("res://levels/level2.tscn").Instantiate();
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
		//GetTree().Root.AddChild(simultaneousScene1);
		level = 1;
		}
		if(level == 1)
		{
		//GetTree().Root.AddChild(simultaneousScene2);	
		level = 2;
		}
		P1Ready = false;
		P2Ready = false;
	}
	}
}
