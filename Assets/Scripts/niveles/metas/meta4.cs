using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000022 RID: 34
public class meta4 : MonoBehaviour
{
	// Token: 0x0600007E RID: 126 RVA: 0x0000417D File Offset: 0x0000237D
	private void Start()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000417F File Offset: 0x0000237F
	private void Update()
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00004184 File Offset: 0x00002384
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN4 == 0)
			{
				manager.gemas++;
				manager.gemaN4 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN4", manager.gemaN4);
			}
			SceneManager.LoadScene("piso2");
		}
	}
}
