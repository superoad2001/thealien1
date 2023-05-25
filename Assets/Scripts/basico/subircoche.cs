using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000012 RID: 18
public class subircoche : MonoBehaviour
{
	// Token: 0x0600003E RID: 62 RVA: 0x00003AE8 File Offset: 0x00001CE8
	private void Start()
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00003AEA File Offset: 0x00001CEA
	private void Update()
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00003AEC File Offset: 0x00001CEC
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player" && manager.tengocoche == 1)
		{
			SceneManager.LoadScene("mundoc");
		}
	}

	// Token: 0x04000072 RID: 114
	public GameObject jugador;
}
