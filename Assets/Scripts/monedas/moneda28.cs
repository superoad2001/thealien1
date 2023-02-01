using System;
using UnityEngine;

// Token: 0x0200003C RID: 60
public class moneda28 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000E6 RID: 230 RVA: 0x000050E7 File Offset: 0x000032E7
	private void Start()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x000050EC File Offset: 0x000032EC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda28 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0000512C File Offset: 0x0000332C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda28 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda28", manager.moneda28);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
