using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200001C RID: 28
public class meta12t : MonoBehaviour
{
	// Token: 0x06000066 RID: 102 RVA: 0x00003DFC File Offset: 0x00001FFC
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager2 manager2 = UnityEngine.Object.FindObjectOfType<manager2>();
			if (col.gameObject.tag == "Player")
			{
				if (manager2.recordnv12 > manager2.contador)
				{
					manager2.recordnv12 = manager2.contador;
					PlayerPrefs.SetFloat("recordnv12", manager2.recordnv12);
				}
				
				SceneManager.LoadScene("piso4t");
			}
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003E78 File Offset: 0x00002078
	private void Start()
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003E7A File Offset: 0x0000207A
	private void Update()
	{
		base.transform.Translate(Vector3.forward * Time.deltaTime / 1.1f * this.velocidad);
	}

	// Token: 0x04000073 RID: 115
	public GameObject jugador;

	// Token: 0x04000074 RID: 116
	public float velocidad = 0.005f;

	// Token: 0x04000075 RID: 117
	private Rigidbody rb;
}
