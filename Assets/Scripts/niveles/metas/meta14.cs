using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200001E RID: 30
public class meta14 : MonoBehaviour
{
	// Token: 0x0600006E RID: 110 RVA: 0x00003F2D File Offset: 0x0000212D
	private void Start()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003F2F File Offset: 0x0000212F
	private void Update()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00003F34 File Offset: 0x00002134
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemas >= 13 && manager.fragmentoN2 == 0)
			{
				manager.fragmento++;
				manager.fragmentoN2 = 1;
				PlayerPrefs.SetInt("fragmento", manager.fragmento);
				PlayerPrefs.SetInt("fragmentoN2", manager.fragmentoN2);
			}
			SceneManager.LoadScene("piso3");
		}
		if (col.gameObject.tag == "coche2")
		{
			SceneManager.LoadScene("piso3");
		}
	}
}
