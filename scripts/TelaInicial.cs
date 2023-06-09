using Godot;
using System;

public partial class TelaInicial : Node2D
{	
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_button_iniciar_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/JogoPrincipal.tscn");
	}


	private void _on_button_credito_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/TelaCreditos.tscn");
	}
	
	private void _on_button_tutorial_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/TelaTutorial.tscn");
	}
	
	private void _on_button_sair_pressed()
	{
		GetTree().Quit();
	}
}



