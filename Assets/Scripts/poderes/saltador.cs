using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class saltador : MonoBehaviour
{
	// Token: 0x06000034 RID: 52 RVA: 0x00003A23 File Offset: 0x00001C23
	private void Start()
	{
	
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003A25 File Offset: 0x00001C25
	private void Update()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003A28 File Offset: 0x00001C28
	private void OnTriggerStay(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		jugador jugador = UnityEngine.Object.FindObjectOfType<jugador>();
		if (col.gameObject.tag == "Player" && manager.tengosalto == 1)
		{

				jugador.tiemposalto = 0.5f;
				jugador.saltoalto();

		}
	}

}
