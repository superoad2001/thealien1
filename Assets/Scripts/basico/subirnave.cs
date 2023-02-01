using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000062 RID: 98
public class subirnave : MonoBehaviour
{
	// Token: 0x0600017E RID: 382 RVA: 0x000066B2 File Offset: 0x000048B2
	private void Start()
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x000066B4 File Offset: 0x000048B4
	private void Update()
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x000066B8 File Offset: 0x000048B8
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player" && manager.tengonave == 1)
		{
			SceneManager.LoadScene("espacio_c");
		}
	}
}
