using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;
using UnityEngine.UI;

// Token: 0x02000007 RID: 7
public class hiper : MonoBehaviour
{
	public bool botonm = false;
	[SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
	public void boton_m()
    {
        botonm = true;
    }
	public void Detenerm()
    {
        botonm = false;
    }
	// Token: 0x06000012 RID: 18 RVA: 0x0000243B File Offset: 0x0000063B
	private void Start()
	{
		player = ReInput.players.GetPlayer(playerID);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000243D File Offset: 0x0000063D
	private void Update()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002440 File Offset: 0x00000640
	private void OnTriggerStay(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player" && manager.tengomejora == 1)
		{
			this.tutfinala.text = "pulsa (click derecho) o (B) para volver a casa";
			if (player.GetAxis("b") > 0f || botonm == true)
			{
				SceneManager.LoadScene("lasalida");
			}
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000024A7 File Offset: 0x000006A7
	private void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			this.tutfinala.text = " ";
		}
	}

	// Token: 0x0400000B RID: 11
	public Text tutfinala;
}
