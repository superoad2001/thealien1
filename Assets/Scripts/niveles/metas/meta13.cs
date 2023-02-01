using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200001D RID: 29
public class meta13 : MonoBehaviour
{
	// Token: 0x0600006A RID: 106 RVA: 0x00003EB3 File Offset: 0x000020B3
	private void Start()
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003EB5 File Offset: 0x000020B5
	private void Update()
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003EB8 File Offset: 0x000020B8
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemas >= 13 && manager.fragmentoN1 == 0)
			{
				manager.fragmento++;
				manager.fragmentoN1 = 1;
				PlayerPrefs.SetInt("fragmento", manager.fragmento);
				PlayerPrefs.SetInt("fragmentoN1", manager.fragmentoN1);
			}
			SceneManager.LoadScene("piso2");
		}
	}
}
