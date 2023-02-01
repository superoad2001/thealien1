using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000026 RID: 38
public class meta8 : MonoBehaviour
{
	// Token: 0x0600008E RID: 142 RVA: 0x0000433D File Offset: 0x0000253D
	private void Start()
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000433F File Offset: 0x0000253F
	private void Update()
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00004344 File Offset: 0x00002544
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN8 == 0)
			{
				manager.gemas++;
				manager.gemaN8 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN8", manager.gemaN8);
			}
			SceneManager.LoadScene("piso3");
		}
		if (col.gameObject.tag == "coche2")
		{
			SceneManager.LoadScene("piso3");
		}
	}
}
