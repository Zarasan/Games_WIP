extends Control


# Declare member variables here. Examples:
# var a = 2
# var b = "text"
var chash
var caps_hash: int = load("res://scenes/godot1.tscn").resource_path.hash()
#var cyl_hash: int = load("res://shared/scenes/pchar_cylinder.tscn").resource_path.hash()
#var cube_hash: int = load("res://shared/scenes/pchar_cuboid.tscn").resource_path.hash()
# Called when the node enters the scene tree for the first time.
func _ready():

	network.connect("server_created",self,"_on_server_created")
	network.connect("join_accepted",self,"_on_join_accepted")
	chash = caps_hash
	network.player_data.add_custom_property("char_class", chash, NetCustomProperty.ReplicationMode.ServerOnly)
	pass # Replace with function body.


func _on_join_pressed():
	network.join_server("127.0.0.1", 1234)
	pass # Replace with function body.


func _on_host_pressed():
	network.create_server(1234, "The Server", 4)
	pass # Replace with function body.


func _on_server_created() -> void:
	get_tree().change_scene("res://Scenes/server.tscn")


func _on_join_accepted() -> void:
	get_tree().change_scene("res://Scenes/server.tscn")
	



func _on_TextureButton_toggled(button_pressed, char_hash):
	if char_hash == "godot1":
		chash = caps_hash
	network.player_data.local_player.set_custom_property("char_class", chash)
	pass # Replace with function body.
