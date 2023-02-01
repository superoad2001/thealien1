using System;
using UnityEngine;

// Token: 0x02000044 RID: 68
public class moneda35 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000106 RID: 262 RVA: 0x000055E7 File Offset: 0x000037E7
	private void Start()
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x000055EC File Offset: 0x000037EC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda35 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0000562C File Offset: 0x0000382C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda35 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda35", manager.moneda35);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
