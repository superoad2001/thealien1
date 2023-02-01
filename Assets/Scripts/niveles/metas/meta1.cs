using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000019 RID: 25
public class meta1 : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00003C7D File Offset: 0x00001E7D
	private void Start()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003C7F File Offset: 0x00001E7F
	private void Update()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003C84 File Offset: 0x00001E84
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN1 == 0)
			{
				manager.gemas++;
				manager.gemaN1 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN1", manager.gemaN1);
			}
			SceneManager.LoadScene("piso1");
		}
	}
}
