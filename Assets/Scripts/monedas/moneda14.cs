using System;
using UnityEngine;

// Token: 0x0200002D RID: 45
public class moneda14 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000AA RID: 170 RVA: 0x00004787 File Offset: 0x00002987
	private void Start()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0000478C File Offset: 0x0000298C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda14 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000047CC File Offset: 0x000029CC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda14 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda14", manager.moneda14);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
