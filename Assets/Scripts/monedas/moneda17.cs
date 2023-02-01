using System;
using UnityEngine;

// Token: 0x02000030 RID: 48
public class moneda17 : MonoBehaviour
{
	public AudioSource audio1;

	// Token: 0x060000B6 RID: 182 RVA: 0x00004967 File Offset: 0x00002B67
	private void Start()
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000496C File Offset: 0x00002B6C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda17 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000049AC File Offset: 0x00002BAC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda17 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda17", manager.moneda17);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
