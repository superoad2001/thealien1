using System;
using UnityEngine;

// Token: 0x02000036 RID: 54
public class moneda22 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000CE RID: 206 RVA: 0x00004D27 File Offset: 0x00002F27
	private void Start()
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00004D2C File Offset: 0x00002F2C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda22 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00004D6C File Offset: 0x00002F6C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda22 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda22", manager.moneda22);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
