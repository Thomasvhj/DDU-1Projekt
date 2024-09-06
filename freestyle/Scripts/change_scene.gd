extends Node2D

var pscene1 = load("res://Scenes/level_1.tscn")
func _ready():
	get_tree().change_scene_to_packed(pscene1)


func onSwitchScene():
	pass
