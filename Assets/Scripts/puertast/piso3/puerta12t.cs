using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200006D RID: 109
public class puerta12t : MonoBehaviour
{
	// Token: 0x060001AA RID: 426 RVA: 0x00006A03 File Offset: 0x00004C03
	private void Start()
	{
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00006A05 File Offset: 0x00004C05
	private void Update()
	{
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00006A08 File Offset: 0x00004C08
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player" && manager.gemas >= 14 && manager.tengollave2 == 1)
		{
			SceneManager.LoadScene("nivel14t");
		}
	}
}
