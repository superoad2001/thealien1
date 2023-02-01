using System;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class moneda3 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000EE RID: 238 RVA: 0x00005227 File Offset: 0x00003427
	private void Start()
	{
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000522C File Offset: 0x0000342C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000526C File Offset: 0x0000346C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda3 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda3", manager.moneda3);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
