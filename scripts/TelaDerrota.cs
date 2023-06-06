using Godot;
using System;

public partial class TelaDerrota : Node2D
{

	game game = new game();

	private void _on_button_reiniciar_pressed()
	{
		Array.Clear(game.descobertas, 0, game.descobertas.Length);
		GetTree().ChangeSceneToFile("res://scenes/JogoPrincipal.tscn");
	}


	private void _on_button_voltar_inicio_pressed()
	{
		Array.Clear(game.descobertas, 0, game.descobertas.Length);
		GetTree().ChangeSceneToFile("res://scenes/TelaInicial.tscn");
	}


	private void _on_button_sair_pressed()
	{
		Array.Clear(game.descobertas, 0, game.descobertas.Length);
		GetTree().Quit();
	}
}



