using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000020 RID: 32
public class meta2 : MonoBehaviour
{
	// Token: 0x06000076 RID: 118 RVA: 0x0000409F File Offset: 0x0000229F
	private void Start()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000040A1 File Offset: 0x000022A1
	private void Update()
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x000040A4 File Offset: 0x000022A4
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN2 == 0)
			{
				manager.gemas++;
				manager.gemaN2 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN2", manager.gemaN2);
			}
			SceneManager.LoadScene("piso1");
		}
	}
}
