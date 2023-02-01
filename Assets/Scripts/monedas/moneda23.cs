using System;
using UnityEngine;

// Token: 0x02000037 RID: 55
public class moneda23 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000D2 RID: 210 RVA: 0x00004DC7 File Offset: 0x00002FC7
	private void Start()
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00004DCC File Offset: 0x00002FCC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda23 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00004E0C File Offset: 0x0000300C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda23 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda23", manager.moneda23);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
