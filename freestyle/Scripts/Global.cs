using Godot;
using System;

public partial class Global : Node2D
{
	public int score = 0;
	
	public override void _Ready()
	{
	}
	public void ScoreAdd(int antal)
	{
		this.score += antal;
	}

public partial class Global : Node
{
	public int score = 0;
	
	public void ScoreAdd(int antal)
	{
		this.score += antal;
		GD.Print("Score er nu:" + this.score);
	}
}
