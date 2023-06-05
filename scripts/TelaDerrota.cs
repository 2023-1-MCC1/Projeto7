using Godot;
using System;

public partial class TelaDerrota : Node2D
{
	private void _on_button_reiniciar_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/JogoPrincipal.tscn");
	}


	private void _on_button_voltar_inicio_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/TelaInicial.tscn");
	}


	private void _on_button_sair_pressed()
	{
		GetTree().Quit();
	}
}



