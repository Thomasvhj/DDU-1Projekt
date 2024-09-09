using Godot;
using System;

public partial class Hud : CanvasLayer
{
	public Label scoreLabel;
	public Global globalVars;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		scoreLabel = GetNode<Label>("GameUI/Score");
		globalVars = GetNode<Global>("/root/Global");
		globalVars.ScoreChanged += _HandleScoreChange;
	}
	public void _HandleScoreChange(string score)
	{
		if(int.Parse(score) < 10)
		{
			score = "000" + score;
		}
		else if(int.Parse(score) < 100)
		{
			score = "00" + score;
		}
		else if(int.Parse(score) < 1000)
		{
			score = "0" + score;
		}
		this.scoreLabel.Text = "SCORE: " + score;
	}
}
