using System;
using UnityEngine;

// Token: 0x02000038 RID: 56
public class moneda24 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000D6 RID: 214 RVA: 0x00004E67 File Offset: 0x00003067
	private void Start()
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00004E6C File Offset: 0x0000306C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda24 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00004EAC File Offset: 0x000030AC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda24 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda24", manager.moneda24);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
