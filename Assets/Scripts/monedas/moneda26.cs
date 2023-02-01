using System;
using UnityEngine;

// Token: 0x0200003A RID: 58
public class moneda26 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000DE RID: 222 RVA: 0x00004FA7 File Offset: 0x000031A7
	private void Start()
	{
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00004FAC File Offset: 0x000031AC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda26 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00004FEC File Offset: 0x000031EC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda26 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda26", manager.moneda26);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
