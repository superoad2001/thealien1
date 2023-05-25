using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000023 RID: 35
public class meta5 : MonoBehaviour
{
	// Token: 0x06000082 RID: 130 RVA: 0x000041ED File Offset: 0x000023ED
	private void Start()
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000041EF File Offset: 0x000023EF
	private void Update()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000041F4 File Offset: 0x000023F4
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN5 == 0)
			{
				manager.gemas++;
				manager.gemaN5 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN5", manager.gemaN5);
			}
			SceneManager.LoadScene("piso2");
		}
	}
}
