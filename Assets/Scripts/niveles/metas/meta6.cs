using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000024 RID: 36
public class meta6 : MonoBehaviour
{
	// Token: 0x06000086 RID: 134 RVA: 0x0000425D File Offset: 0x0000245D
	private void Start()
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000425F File Offset: 0x0000245F
	private void Update()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00004264 File Offset: 0x00002464
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN6 == 0)
			{
				manager.gemas++;
				manager.gemaN6 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN6", manager.gemaN6);
			}
			SceneManager.LoadScene("piso2");
		}
	}
}
