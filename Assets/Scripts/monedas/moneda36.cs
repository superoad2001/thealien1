using System;
using UnityEngine;

// Token: 0x02000045 RID: 69
public class moneda36 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600010A RID: 266 RVA: 0x00005687 File Offset: 0x00003887
	private void Start()
	{
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0000568C File Offset: 0x0000388C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda36 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x000056CC File Offset: 0x000038CC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda36 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda36", manager.moneda36);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
