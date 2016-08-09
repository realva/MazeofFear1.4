// Trabalho Computação Gráfica 2016.1
#pragma strict
// Start é chamada na inicialização.
function Start () {

	yield WaitForSeconds(7);
	Application.LoadLevel("TelaFinalReiniciar"); // Controle de fluxo descolado para a tela final auxiliar.

}
// Update é chamada a cada frame na execução.
function Update () {

}