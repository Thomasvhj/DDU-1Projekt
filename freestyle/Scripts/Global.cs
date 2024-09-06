using Godot;
using System;


public partial class Global : Node
{
	[Signal]
	public delegate void ScoreChangedEventHandler(string score);
	
	public int score = 0;
	
	public void ScoreAdd(int antal)
	{
		this.score += antal;
		EmitSignal(SignalName.ScoreChanged, this.score);
		GD.Print("Score er nu: " + this.score);
	}
}
