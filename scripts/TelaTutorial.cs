using Godot;
using System;

public partial class TelaTutorial : Node2D
{
	private void _on_button_voltar_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/TelaInicial.tscn");
	}
}
