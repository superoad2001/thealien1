using System;
using UnityEngine;

// Token: 0x02000046 RID: 70
public class moneda37 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600010E RID: 270 RVA: 0x00005727 File Offset: 0x00003927
	private void Start()
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x0000572C File Offset: 0x0000392C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda37 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000576C File Offset: 0x0000396C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda37 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda37", manager.moneda37);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
