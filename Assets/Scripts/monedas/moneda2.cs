using System;
using UnityEngine;

// Token: 0x02000033 RID: 51
public class moneda2 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000C2 RID: 194 RVA: 0x00004B47 File Offset: 0x00002D47
	private void Start()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00004B4C File Offset: 0x00002D4C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda2 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00004B8C File Offset: 0x00002D8C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.monedas++;
		manager.moneda2 = 1;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda2", manager.moneda2);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
