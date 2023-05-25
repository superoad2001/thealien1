using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200001A RID: 26
public class meta10 : MonoBehaviour
{
	// Token: 0x0600005E RID: 94 RVA: 0x00003CEC File Offset: 0x00001EEC
	private void Start()
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003CEE File Offset: 0x00001EEE
	private void Update()
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00003CF0 File Offset: 0x00001EF0
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN10 == 0)
			{
				manager.gemas++;
				manager.gemaN10 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN10", manager.gemaN10);
			}
			SceneManager.LoadScene("piso4");
		}
	}
}
