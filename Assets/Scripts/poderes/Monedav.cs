using System;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class Monedav : MonoBehaviour
{
	public AudioSource audio;
	// Token: 0x06000028 RID: 40 RVA: 0x000038FA File Offset: 0x00001AFA
	private void Start()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000038FC File Offset: 0x00001AFC
	private void Update()
	{
	}
	public int velocidadmaxima = 20;
	// Token: 0x0600002A RID: 42 RVA: 0x00003900 File Offset: 0x00001B00
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player" && manager.tengovel == 1)
		{
			jugador jugador = UnityEngine.Object.FindObjectOfType<jugador>();
			jugador.tiempovel = 0f;
			jugador.tiempovelint = 0;
			jugador.velocidad = jugador.velocidadaux;
			jugador.velozidad();
			jugador.velocidad = this.velocidadmaxima;
			audio.Play();
		}
	}
}
