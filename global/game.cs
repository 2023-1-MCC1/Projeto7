using Godot;
using System;

public partial class game : Node
{

	public int pontos = 0;
	public int pontosLim = 500;

	public int extintos = 0;
	public int extintosLim = 3;

	public static string peixe;

	public static string estacao;

	public static bool extinto = false;

	public static String[] descobertas = new String[9];

	public void pescar(){

		var random = new RandomNumberGenerator();
		JogoPrincipal jogo = new JogoPrincipal();
		
		var pesca = random.RandiRange(0, 100);

		if(pesca <= 20){
			peixe = "Atum";
		}
		else  if(pesca <= 40){
			peixe = "Salmao";
		}
		else if(pesca <= 60){
			peixe = "Tainha";
		}
		else if(pesca <= 80){
			peixe = "Tilapia";
		}
		else if(pesca <= 85){
			peixe = "Dourado";
		}
		else if(pesca <= 100){      //0 = verao; 1 = outono; 2 = inverno; 3 = primavera
			if(estacao == "verao"){
				peixe = "Palhaco";
			}
			else if(estacao == "outono"){
				peixe = "Cascudo";
			}
			else if(estacao == "inverno"){
				peixe = "Lanterna";
			}
			else if(estacao == "primavera"){
				peixe = "Leao";
			}
		}

		GD.Print("pescou! Você pegou o: " + peixe);
		GD.Print("Voce está na estação: " + estacao);

	}
	
	public void pegar(){
		var random = new RandomNumberGenerator();
		pontos += 10;
		GD.Print("pegou!");
		if(peixe == "Atum"){
			descobertas[0] = peixe;
		}
		else if(peixe == "Salmao"){
			descobertas[1] = peixe;
		}
		else if(peixe == "Tainha"){
			descobertas[2] = peixe;
		}
		else if(peixe == "Tilapia"){
			descobertas[3] = peixe;
		}
		else if(peixe == "Dourado"){
			descobertas[4] = peixe;
			pontos += 200;
		}
		else if(peixe == "Leao"){
			descobertas[5] = peixe;
		}
		else if(peixe == "Palhaco"){
			descobertas[6] = peixe;
		}
		else if(peixe == "Lanterna"){
			descobertas[7] = peixe;
		}
		else if(peixe == "Cascudo"){
			descobertas[8] = peixe;
		}

		var extinguiu = random.RandiRange(0, 100);
		var chanceNormal = 95;
		var chanceEstacao = 65;
		var chanceDourado = 20;

		//salmão:
		if(peixe == "Salmao"){
			if(estacao != "verao" && extinguiu >= chanceNormal){
				extintos += 1;
				extinto = true;
				GD.Print("Você extinguiu o salmão!");
			}
			else if(estacao == "verao" && extinguiu >= chanceEstacao){
				extintos += 1;
				extinto = true;
				GD.Print("Você extinguiu o salmão!");
			}
		}

		//tilápia:
		if(peixe == "Tilapia"){
			if(estacao != "inverno" && extinguiu >= chanceNormal){
				extintos += 1;
				extinto = true;
				GD.Print("Você extinguiu a tilápia!");
			}
			else if(estacao == "inverno" && extinguiu >= chanceEstacao){
				extintos += 1;
				extinto = true;
				GD.Print("Você extinguiu a tilápia!");
			}
		}

		//atum
		if(peixe == "Atum"){
			if(estacao != "primavera" && extinguiu >= chanceNormal){
				extintos += 1;
				extinto = true;
				GD.Print("Você extinguiu o atum!");
			}
			else if(estacao == "primavera" && extinguiu >= chanceEstacao){
				extintos += 1;
				extinto = true;
				GD.Print("Você extinguiu o atum!");
			}
		}

		//tainha
		if(peixe == "Tainha"){
			if(estacao != "outono" && extinguiu >= chanceNormal){
				extintos += 1;
				extinto = true;
				GD.Print("Você extinguiu a tainha!");
			}
			else if(estacao == "outono" && extinguiu >= chanceEstacao){
				extintos += 1;
				extinto = true;
				GD.Print("Você extinguiu a tainha!");
			}
		}

		//dourado
		if(peixe == "Dourado" && extinguiu >= chanceDourado){
			extintos += 1;
			extinto = true;
			GD.Print("Você extinguiu o dourado!");
		}
	}

	public void soltar(){
		GD.Print("soltou!");
	}

	public void verificarVitoria(){
		if(pontos >= pontosLim){

		}
	}
}
