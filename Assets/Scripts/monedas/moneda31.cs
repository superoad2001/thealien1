using System;
using UnityEngine;

// Token: 0x02000040 RID: 64
public class moneda31 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000F6 RID: 246 RVA: 0x00005367 File Offset: 0x00003567
	private void Start()
	{
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000536C File Offset: 0x0000356C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda31 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x000053AC File Offset: 0x000035AC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda31 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda31", manager.moneda31);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
