using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

// Token: 0x0200000B RID: 11
public class manager : MonoBehaviour
{
	public int plat = 1;
	public AudioSource audio;
	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;
	public AudioSource audio4;
	public AudioSource audio5;
	public AudioSource audio6;
	public AudioSource audio7;
	public AudioSource audioen;
	public AudioSource audio1en;
	public AudioSource audio2en;
	public AudioSource audio3en;
	public AudioSource audio4en;
	public AudioSource audio5en;
	public AudioSource audio6en;
	public AudioSource audio7en;
	public AudioSource audiocat;
	public AudioSource audio1cat;
	public AudioSource audio2cat;
	public AudioSource audio3cat;
	public AudioSource audio4cat;
	public AudioSource audio5cat;
	public AudioSource audio6cat;
	public AudioSource audio7cat;
	public int plataforma;
	public int mejora1;
	public int mejora2;
	public int mejora3;
	public int mejora4;
	public int mejora5;
	public string idioma;
	public Text boton1;
	public Text boton2;
	public Text boton3;
	public Text boton4;
	public Text boton5;
	public Text boton6;
	public Text boton7;
	public int menu = 0;
	public int estados = 0;
	public int tuto = 0;
	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C
	private void Awake() {
	{
		this.idioma = PlayerPrefs.GetString("idioma", "es");
		this.plataforma = PlayerPrefs.GetInt("plataforma", plat);
	}
	}
	private void Start()
	{
		jugador jugador = UnityEngine.Object.FindObjectOfType<jugador>();
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();


		this.mejora1 = PlayerPrefs.GetInt("mejorac1", 0);
		this.mejora2 = PlayerPrefs.GetInt("mejorac2", 0);
		this.mejora3 = PlayerPrefs.GetInt("mejorac3", 0);
		this.mejora4 = PlayerPrefs.GetInt("mejorac4", 0);
		this.mejora5 = PlayerPrefs.GetInt("mejorac5", 0);
		this.tengomejora = PlayerPrefs.GetInt("tengomejora", 0);
		this.cinematicaf = PlayerPrefs.GetInt("cinfinal", 0);
		this.gema1 = PlayerPrefs.GetInt("gema1", 0);
		this.gema2 = PlayerPrefs.GetInt("gema2", 0);
		this.gema3 = PlayerPrefs.GetInt("gema3", 0);
		this.gemaN1 = PlayerPrefs.GetInt("gemaN1", 0);
		this.gemaN2 = PlayerPrefs.GetInt("gemaN2", 0);
		this.gemaN3 = PlayerPrefs.GetInt("gemaN3", 0);
		this.gemaN4 = PlayerPrefs.GetInt("gemaN4", 0);
		this.gemaN5 = PlayerPrefs.GetInt("gemaN5", 0);
		this.gemaN6 = PlayerPrefs.GetInt("gemaN6", 0);
		this.gemaN7 = PlayerPrefs.GetInt("gemaN7", 0);
		this.gemaN8 = PlayerPrefs.GetInt("gemaN8", 0);
		this.gemaN9 = PlayerPrefs.GetInt("gemaN9", 0);
		this.gemaN10 = PlayerPrefs.GetInt("gemaN10", 0);
		this.gemaN11 = PlayerPrefs.GetInt("gemaN11", 0);
		this.gemaN12 = PlayerPrefs.GetInt("gemaN12", 0);
		this.fragmento = PlayerPrefs.GetInt("fragmento", 0);
		this.fragmentoN1 = PlayerPrefs.GetInt("fragmentoN1", 0);
		this.fragmentoN2 = PlayerPrefs.GetInt("fragmentoN2", 0);
		this.fragmentoN3 = PlayerPrefs.GetInt("fragmentoN3", 0);
		this.tengosalto = PlayerPrefs.GetInt("salto", 0);
		this.tengocoche = PlayerPrefs.GetInt("coche", 0);
		this.tengovel = PlayerPrefs.GetInt("vel", 0);
		this.tengonave = PlayerPrefs.GetInt("nave", 0);
		this.gemas = PlayerPrefs.GetInt("gemas", 0);
		this.monedas = PlayerPrefs.GetInt("monedas", 0);
		this.tengollave1 = PlayerPrefs.GetInt("llave1", 0);
		this.tengollave2 = PlayerPrefs.GetInt("llave2", 0);
		this.tengollave3 = PlayerPrefs.GetInt("llave3", 0);
		this.tengollave4 = PlayerPrefs.GetInt("llave4", 0);
		this.moneda1 = PlayerPrefs.GetInt("moneda1", 0);
		this.moneda2 = PlayerPrefs.GetInt("moneda2", 0);
		this.moneda3 = PlayerPrefs.GetInt("moneda3", 0);
		this.moneda4 = PlayerPrefs.GetInt("moneda4", 0);
		this.moneda5 = PlayerPrefs.GetInt("moneda5", 0);
		this.moneda6 = PlayerPrefs.GetInt("moneda6", 0);
		this.moneda7 = PlayerPrefs.GetInt("moneda7", 0);
		this.moneda8 = PlayerPrefs.GetInt("moneda8", 0);
		this.moneda9 = PlayerPrefs.GetInt("moneda9", 0);
		this.moneda10 = PlayerPrefs.GetInt("moneda10", 0);
		this.moneda11 = PlayerPrefs.GetInt("moneda11", 0);
		this.moneda12 = PlayerPrefs.GetInt("moneda12", 0);
		this.moneda13 = PlayerPrefs.GetInt("moneda13", 0);
		this.moneda14 = PlayerPrefs.GetInt("moneda14", 0);
		this.moneda15 = PlayerPrefs.GetInt("moneda15", 0);
		this.moneda16 = PlayerPrefs.GetInt("moneda16", 0);
		this.moneda17 = PlayerPrefs.GetInt("moneda17", 0);
		this.moneda18 = PlayerPrefs.GetInt("moneda18", 0);
		this.moneda19 = PlayerPrefs.GetInt("moneda19", 0);
		this.moneda20 = PlayerPrefs.GetInt("moneda20", 0);
		this.moneda21 = PlayerPrefs.GetInt("moneda21", 0);
		this.moneda22 = PlayerPrefs.GetInt("moneda22", 0);
		this.moneda23 = PlayerPrefs.GetInt("moneda23", 0);
		this.moneda24 = PlayerPrefs.GetInt("moneda24", 0);
		this.moneda25 = PlayerPrefs.GetInt("moneda25", 0);
		this.moneda26 = PlayerPrefs.GetInt("moneda26", 0);
		this.moneda27 = PlayerPrefs.GetInt("moneda27", 0);
		this.moneda28 = PlayerPrefs.GetInt("moneda28", 0);
		this.moneda29 = PlayerPrefs.GetInt("moneda29", 0);
		this.moneda30 = PlayerPrefs.GetInt("moneda30", 0);
		this.moneda31 = PlayerPrefs.GetInt("moneda31", 0);
		this.moneda32 = PlayerPrefs.GetInt("moneda32", 0);
		this.moneda33 = PlayerPrefs.GetInt("moneda33", 0);
		this.moneda34 = PlayerPrefs.GetInt("moneda34", 0);
		this.moneda35 = PlayerPrefs.GetInt("moneda35", 0);
		this.moneda36 = PlayerPrefs.GetInt("moneda36", 0);
		this.moneda37 = PlayerPrefs.GetInt("moneda37", 0);
		this.moneda38 = PlayerPrefs.GetInt("moneda38", 0);
		this.moneda39 = PlayerPrefs.GetInt("moneda39", 0);
		this.moneda40 = PlayerPrefs.GetInt("moneda40", 0);
		this.moneda41 = PlayerPrefs.GetInt("moneda41", 0);
		this.moneda42 = PlayerPrefs.GetInt("moneda42", 0);
		this.moneda43 = PlayerPrefs.GetInt("moneda43", 0);
		this.moneda44 = PlayerPrefs.GetInt("moneda44", 0);
		this.moneda45 = PlayerPrefs.GetInt("moneda45", 0);
		this.moneda46 = PlayerPrefs.GetInt("moneda46", 0);
		this.moneda47 = PlayerPrefs.GetInt("moneda47", 0);
		this.moneda48 = PlayerPrefs.GetInt("moneda48", 0);
		this.moneda49 = PlayerPrefs.GetInt("moneda49", 0);
		this.moneda50 = PlayerPrefs.GetInt("moneda50", 0);
		if(idioma == "es")
		{
			if (this.piso == 1 && this.gemas == 0 && jugador.dentrotienda == false)
			{
				audio.Play();
			}
			if (this.piso == 1 && this.gemas >= 1 && this.gemas <= 3 && tengovel == 0 && jugador.dentrotienda == false)
			{
				audio1.Play();
			}
			
			if (this.piso == 1 && this.gemas >= 3 && this.gemas <= 6 && jugador.dentrotienda == false && tengovel == 1 && tengocoche == 0)
			{
				audio2.Play();
			}
			if (this.piso == 1 && this.gemas >= 6 && this.gemas <= 9 && tengocoche == 1 && jugador.dentrotienda == false && tengosalto == 0)
			{
				audio3.Play();
			}
			if (this.piso == 1 && this.gemas >= 9 && this.gemas <= 12 && tengosalto == 1 && jugador.dentrotienda == false && tengonave == 0)
			{
				audio4.Play();
			}
			if (this.piso == 1 && this.gemas >= 12 && tengonave == 1 && jugador.dentrotienda == false && fragmento < 3 && tengomejora == 0 && tengollave4 == 0)
			{
				audio5.Play();
			}
			if (this.piso == 1 && this.gemas == 15 && tengomejora == 0 && jugador.dentrotienda == false && fragmento == 3 && tengollave4 == 0 && monedas == 50)
			{
				audio6.Play();
			}
		}
		if(idioma == "en")
		{
			if (this.piso == 1 && this.gemas == 0 && jugador.dentrotienda == false)
			{
				audioen.Play();
			}
			if (this.piso == 1 && this.gemas >= 1 && this.gemas <= 3 && tengovel == 0 && jugador.dentrotienda == false)
			{
				audio1en.Play();
			}
			
			if (this.piso == 1 && this.gemas >= 3 && this.gemas <= 6 && jugador.dentrotienda == false && tengovel == 1 && tengocoche == 0)
			{
				audio2en.Play();
			}
			if (this.piso == 1 && this.gemas >= 6 && this.gemas <= 9 && tengocoche == 1 && jugador.dentrotienda == false && tengosalto == 0)
			{
				audio3en.Play();
			}
			if (this.piso == 1 && this.gemas >= 9 && this.gemas <= 12 && tengosalto == 1 && jugador.dentrotienda == false && tengonave == 0)
			{
				audio4en.Play();
			}
			if (this.piso == 1 && this.gemas >= 12 && tengonave == 1 && jugador.dentrotienda == false && fragmento < 3 && tengomejora == 0 && tengollave4 == 0)
			{
				audio5en.Play();
			}
			if (this.piso == 1 && this.gemas == 15 && tengomejora == 0 && jugador.dentrotienda == false && fragmento == 3 && tengollave4 == 0 && monedas == 50)
			{
				audio6en.Play();
			}
		}
		if(idioma == "cat")
		{
			if (this.piso == 1 && this.gemas == 0 && jugador.dentrotienda == false)
			{
				audiocat.Play();
			}
			if (this.piso == 1 && this.gemas >= 1 && this.gemas <= 3 && tengovel == 0 && jugador.dentrotienda == false)
			{
				audio1cat.Play();
			}
			
			if (this.piso == 1 && this.gemas >= 3 && this.gemas <= 6 && jugador.dentrotienda == false && tengovel == 1 && tengocoche == 0)
			{
				audio2cat.Play();
			}
			if (this.piso == 1 && this.gemas >= 6 && this.gemas <= 9 && tengocoche == 1 && jugador.dentrotienda == false && tengosalto == 0)
			{
				audio3cat.Play();
			}
			if (this.piso == 1 && this.gemas >= 9 && this.gemas <= 12 && tengosalto == 1 && jugador.dentrotienda == false && tengonave == 0)
			{
				audio4cat.Play();
			}
			if (this.piso == 1 && this.gemas >= 12 && tengonave == 1 && jugador.dentrotienda == false && fragmento < 3 && tengomejora == 0 && tengollave4 == 0)
			{
				audio5cat.Play();
			}
			if (this.piso == 1 && this.gemas == 15 && tengomejora == 0 && jugador.dentrotienda == false && fragmento == 3 && tengollave4 == 0 && monedas == 50)
			{
				audio6cat.Play();
			}
		}
	}
	public bool mundos = false;
		// Token: 0x04000021 RID: 33
	public bool unavez = true;

	// Token: 0x04000022 RID: 34
	public GameObject jugador1;

	// Token: 0x04000023 RID: 35
	public GameObject jefe1;

	// Token: 0x04000024 RID: 36
	public Camera normal;

	// Token: 0x04000025 RID: 37
	public float tiement;

	// Token: 0x04000026 RID: 38
	public int juego;

	// Token: 0x04000027 RID: 39
	public bool tutorial;

	// Token: 0x04000028 RID: 40
	public int espacio = 0;

	public int gemas;

	public int gemaN1;

	public int gemaN2;

	public int gemaN3;

	public int gemaN4;

	public int gemaN5;

	public int gemaN6;

	public int gemaN7;

	public int gemaN8;

	public int gemaN9;

	public int gemaN10;

	public int gemaN11;

	public int gemaN12;

	public int fragmentoN1;

	public int fragmentoN2;

	public int fragmentoN3;

	public Text mision;

	public Text mision2;

	// Token: 0x04000029 RID: 41
	public Text cuentagemas;

	// Token: 0x0400002A RID: 42
	public Text cuentamonedas;

	// Token: 0x0400002B RID: 43
	public Text cuentafrag;

	// Token: 0x0400002C RID: 44
	public int monedas;

	// Token: 0x0400002D RID: 45
	public int tengovel;

	// Token: 0x0400002E RID: 46
	public int tengocoche;

	// Token: 0x0400002F RID: 47
	public int tengosalto;

	// Token: 0x04000030 RID: 48
	public int tengonave;

	// Token: 0x04000031 RID: 49
	public int piso = 0;

	// Token: 0x04000032 RID: 50
	public int fragmento;

	// Token: 0x04000033 RID: 51
	public int tengollave1;

	// Token: 0x04000034 RID: 52
	public int tengollave2;

	// Token: 0x04000035 RID: 53
	public int tengollave3;

	// Token: 0x04000036 RID: 54
	public int tengollave4;

	// Token: 0x04000037 RID: 55
	public int cinematicaf;

	// Token: 0x04000038 RID: 56
	public int tengomejora;

	// Token: 0x04000039 RID: 57
	public int gema1;

	// Token: 0x0400003A RID: 58
	public int gema2;

	// Token: 0x0400003B RID: 59
	public int gema3;

	// Token: 0x0400003C RID: 60
	public int moneda1;

	// Token: 0x0400003D RID: 61
	public int moneda2;

	// Token: 0x0400003E RID: 62
	public int moneda3;

	// Token: 0x0400003F RID: 63
	public int moneda4;

	// Token: 0x04000040 RID: 64
	public int moneda5;

	// Token: 0x04000041 RID: 65
	public int moneda6;

	// Token: 0x04000042 RID: 66
	public int moneda7;

	// Token: 0x04000043 RID: 67
	public int moneda8;

	// Token: 0x04000044 RID: 68
	public int moneda9;

	// Token: 0x04000045 RID: 69
	public int moneda10;

	// Token: 0x04000046 RID: 70
	public int moneda11;

	// Token: 0x04000047 RID: 71
	public int moneda12;

	// Token: 0x04000048 RID: 72
	public int moneda13;

	// Token: 0x04000049 RID: 73
	public int moneda14;

	// Token: 0x0400004A RID: 74
	public int moneda15;

	// Token: 0x0400004B RID: 75
	public int moneda16;

	// Token: 0x0400004C RID: 76
	public int moneda17;

	// Token: 0x0400004D RID: 77
	public int moneda18;

	// Token: 0x0400004E RID: 78
	public int moneda19;

	// Token: 0x0400004F RID: 79
	public int moneda20;

	// Token: 0x04000050 RID: 80
	public int moneda21;

	// Token: 0x04000051 RID: 81
	public int moneda22;

	// Token: 0x04000052 RID: 82
	public int moneda23;

	// Token: 0x04000053 RID: 83
	public int moneda24;

	// Token: 0x04000054 RID: 84
	public int moneda25;

	// Token: 0x04000055 RID: 85
	public int moneda26;

	// Token: 0x04000056 RID: 86
	public int moneda27;

	// Token: 0x04000057 RID: 87
	public int moneda28;

	// Token: 0x04000058 RID: 88
	public int moneda29;

	// Token: 0x04000059 RID: 89
	public int moneda30;

	// Token: 0x0400005A RID: 90
	public int moneda31;

	// Token: 0x0400005B RID: 91
	public int moneda32;

	// Token: 0x0400005C RID: 92
	public int moneda33;

	// Token: 0x0400005D RID: 93
	public int moneda34;

	// Token: 0x0400005E RID: 94
	public int moneda35;

	// Token: 0x0400005F RID: 95
	public int moneda36;

	// Token: 0x04000060 RID: 96
	public int moneda37;

	// Token: 0x04000061 RID: 97
	public int moneda38;

	// Token: 0x04000062 RID: 98
	public int moneda39;

	// Token: 0x04000063 RID: 99
	public int moneda40;

	// Token: 0x04000064 RID: 100
	public int moneda41;

	// Token: 0x04000065 RID: 101
	public int moneda42;

	// Token: 0x04000066 RID: 102
	public int moneda43;

	// Token: 0x04000067 RID: 103
	public int moneda44;

	// Token: 0x04000068 RID: 104
	public int moneda45;

	// Token: 0x04000069 RID: 105
	public int moneda46;

	// Token: 0x0400006A RID: 106
	public int moneda47;

	// Token: 0x0400006B RID: 107
	public int moneda48;

	// Token: 0x0400006C RID: 108
	public int moneda49;

	// Token: 0x0400006D RID: 109
	public int moneda50;

	// Token: 0x06000026 RID: 38 RVA: 0x000037BC File Offset: 0x000019BC
	private void Update()
	{
		jugador jugador = UnityEngine.Object.FindObjectOfType<jugador>();
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		

	if(idioma == "es")
	{
		if(tuto == -2)
		{
			boton2.text = "muevete con los botones de (wasd) o joystick";
			boton3.text = "pulsa (x) o click izquierdo para subir y pulsa (b) o click derecho  para bajar en el ascensor";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == -1)
		{
			boton2.text = "muevete con los botones de (wasd) o joystick pulsa (espacio) o (a) para avanzar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 1)
		{
			boton2.text = "wasd o joystick para moverse pulsa (espacio) o (a) para saltar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 2)
		{
			boton2.text = "pulsa y manten (espacio) o (a) para planear";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 3)
		{
			boton2.text = "pulsa (a) y (d) o joystick para desplazarte lateralmente apreta (click derecho) o (b) para cambiar de prespectiva y (espacio) o (a) para saltar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 4)
		{
			boton2.text = "toca las fichas aceleradoras para aumentar la logitud de los saltos";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 8)
		{
			boton2.text = "wasd o joystick para moverse, pulsa (espacio) o (a) para acelerar apreta (click derecho) o (b) para ir atras,agarra los aceleradores para ir mas rapido queda puesto 1 para ganar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 9)
		{
			boton2.text = "wasd o joystick para moverse, pulsa (espacio) o (a) para acelerar apreta (click derecho) o (b) para ir atras,agarra los aceleradores para ir mas rapido esquiva los obstaculos, queda puesto 1 para ganar";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 10)
		{
			boton2.text = "apreta (espacio) encima de un saltador para llegar mas alto";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 11)
		{
			boton2.text = "wasd o joystick para moverse, pulsa (espacio) o (a) para acelerar apreta (click derecho) o (b) para ir atras,agarra los aceleradores para ir mas rapido esquiva los obstaculos y queda puesto 1 para ganar acelera en el saltador para subir a la roca";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(tuto == 12)
		{
			boton2.text = "wasd o joystick para moverse ypulsa (espacio) o (a) para saltar toca la nave enemiga para ganary no te olvides de agarrar las monedas de velocidad para alanzar al la nave de vendedor";
			boton1.text = "Apreta (espacio) o (a) para continuar";
		}
		if(estados == 1)
		{
			boton1.text = "pulsa (click derecho) o (b) para subir a nave";
		}
		if(estados == 2)
		{
			boton1.text = "pulsa (click derecho) o (b) para subir al ascensor";
		}
		if(estados == 3)
		{
			boton1.text = "(click izquierdo) o (x) para bajar de planta";
			boton2.text = "tiempos";
		}
		if(estados == 4)
		{
			boton1.text = "SALA DEL REY";
		}
		if(estados == 5)
		{
			boton1.text = "SALA SECRETA";
		}
		if(menu == 1)
		{
			boton1.text = "borrar partida";
			boton2.text = "opciones";
			boton3.text = "comenzar partida";
		}
		if(menu == -1)
		{
			boton1.text = "presenta";
		}
		if(menu == -2)
		{
			boton1.text = "saltar";
		}
		if(menu == 2)
		{
			boton1.text = "estas seguro?";
			boton2.text = "borrar partida";
			boton3.text = "volver atras";
		}
		if(menu == 3)
		{
			boton1.text = "controles";
			boton2.text = "teclado y raton o mando";
			boton3.text = "tactil (solo android)";
			boton4.text = "idioma";
		}
		if(menu == 4)
		{
			boton1.text = "FIN";
			boton2.text = "volver al menu";

		}
		if(menu == 5)
		{
			boton1.text = "controles";
			boton2.text = "pc o consola";
			boton3.text = "dispositivo tactil";
			boton4.text = "en que dispositivo estas jugando?";
			boton5.text = "si estas jugando en un pc tableta o android selecciona dispositivo tactil si estas en los anteriores dispositivos con un mando o en pc o consola selecciona pc o consola";
			boton6.text = "una vez selecionado para cambiarlo entra a opciones";
		}
		if (this.juego == 0 && this.piso == 1 && jugador.dentrotienda == true)
		{
			this.cuentamonedas.text = "monedas:  " + this.monedas;
			this.cuentagemas.text = "gemas:  " + this.gemas;
			this.cuentafrag.text = "fragmentos de gran gema: " + this.fragmento + "/3";

		}
		if (this.juego == 0 && this.piso == 1 && jugador.dentrotienda == false || this.juego == 0 && this.piso == 2 && jugador.dentrotienda == false|| this.juego == 0 && this.piso == 3 && jugador.dentrotienda == false|| this.juego == 0 && this.piso == 4 && jugador.dentrotienda == false)
		{
			this.cuentamonedas.text = "monedas:  " + this.monedas;
			this.cuentagemas.text = "gemas:  " + this.gemas;
			this.cuentafrag.text = "fragmentos de gran gema: " + this.fragmento + "/3";

			if (gemas == 0)
			{
				this.mision.text = "MISION: cruza una puerta y consigue una gema completando un nivel";
			}
			if (gemas == 1 && monedas < 10)
			{
				this.mision.text = "MISION: haz los 2 niveles que quedan y baja abajo y consigue 10 monedas";
			}
			if (gemas == 2 && monedas < 10)
			{
				this.mision.text = "MISION: haz el nivel que te queda y baja abajo y consigue 10 monedas";
			}
			if (gemas == 3 && monedas < 10)
			{
				this.mision.text = "MISION: baja abajo y consigue 10 monedas";
			}
			if (gemas == 1 && monedas == 10)
			{
				this.mision.text = "MISION: haz los 2 niveles que quedan";
			}
			if (gemas == 2 && monedas == 10)
			{
				this.mision.text = "MISION: haz el nivel que te queda";
			}
			if (gemas == 3 && monedas == 10 && tengovel == 0)
			{
				this.mision.text = "MISION: ve a la tienda del primer  piso y recoge el acelerador";
			}
			if (gemas <= 6 && monedas <= 20 && tengovel == 1)
			{
				this.mision.text = "MISION: sube al segundo piso y consigue 6 gemas  baja al espacio y llega a las 20 monedas usando el acelerador";
			}
			if (gemas == 6 && monedas == 20 && tengocoche == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge tu nuevo coche";
			}
			if (gemas <= 9 && monedas <= 30 && tengocoche == 1)
			{
				this.mision.text = "MISION: sube al tercer piso y consigue 9 gemas                                                     baja al espacio y llega a las 30 monedas usando el coche para usarlo tocalo";
			}
			if (gemas == 9 && monedas == 30 && tengosalto == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge el saltador";
			}
			if (gemas <= 12 && monedas <= 40 && tengosalto == 1)
			{
				this.mision.text = "MISION: sube al cuarto piso y consigue 12 gemas                                                     baja al espacio y llega a las 40 monedas usando el saltador";
			}
			if (gemas == 12 && monedas == 40 && tengonave == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge la nave espacial";
			}
			if (gemas == 12 && monedas == 40 && tengonave == 1)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 13 gemas";
			}
			if (gemas == 13 && tengonave == 1 && tengollave1 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2 ";
			}
			if (gemas == 13 &&  tengonave == 1 && tengollave1 == 1 && tengollave2 == 0 && tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 14 gemas";
			}
			if (gemas == 14 && tengonave == 1 && tengollave1 == 1 && tengollave2 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 3 ";
			}
			if (gemas == 14 &&  tengonave == 1 && tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 15 gemas";
			}
			if (gemas == 15 && tengonave == 1 && tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 4 ";
			}
			if (gemas == 14 && tengonave == 1 && tengollave1 == 0 && tengollave2 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2 y 3 ";
			}
			if (gemas == 15 && tengonave == 1 && tengollave1 == 0 && tengollave2 == 0 && tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2,3 y 4 ";
			}
			if (tengollave1 == 1 && tengollave2 == 0 && tengollave3 == 0 && fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 3 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2, 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 1 && fragmentoN1 == 1 && fragmentoN2 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al tercer piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 0 && fragmentoN1 == 0 && fragmentoN2 == 0 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2, 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 1 && fragmentoN2 == 0 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 1 && fragmentoN2 == 1 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al cuarto piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 0 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 3 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 0 && fragmentoN2 == 1 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 1 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 1 && fragmentoN2 == 0 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al tercer piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (fragmento == 3 && monedas < 50 && tengollave4 == 0)
			{
				this.mision.text = "MISION fase 3: consigue 50 monedas por el espacio";
			}
			if (fragmento == 3 && monedas == 50 && tengollave4 == 0)
			{
				this.mision.text = "MISION fase 3: ve a la tienda y recoje la llave del quinto piso";
			}

			if (fragmento == 3 && tengollave4 == 1 && tengomejora == 0)
			{
				this.mision.text = "MISION fase 3: recoje el hiperpropulsor en el quinto piso";
			}
			if (fragmento == 3 && tengomejora == 1)
			{
				this.mision.text = "MISION fase final: ve al espacio con la nave y largate de esta galaxia                 has desbloqueado la torre del tiempo sube arriba del quinto piso y supera tus records";
			}
			

			
		}
		if (piso == 5 && tengomejora == 1)
		{
			this.mision.text = "MISION fase final: ve al espacio con la nave y largate de esta galaxia                 has desbloqueado la torre del tiempo sube arriba del quinto piso y supera los records negtivos";
		}
		if (this.juego == 4 && this.piso == 10 || this.juego == 1 && this.piso == 10 || this.juego == 4 && this.piso == 1)
		{
			this.cuentamonedas.text = "monedas:  " + this.monedas;
		}
				if (this.juego == 4 && this.piso == 10 && this.mundos == true || this.juego == 1 && this.piso == 10 && this.mundos == true || this.juego == 4 && this.piso == 1 && this.mundos == true )
		{
			this.cuentagemas.text = "gemas:  " + this.gemas;
		}
		if (juego == 6 && tengomejora == 1)
		{
			this.mision.text = "MISION fase final: vuela arriba a la plataforma de aterrizaje y sal de esta galaxia";
		}
		}
	if(idioma == "en")
	{
		if(tuto == -2)
		{
			boton2.text = "move with the buttons (wasd) or joystick";
			boton3.text = "press (x) or (left click) to go up and press (b) or (right click) to go down in the elevator";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == -1)
		{
			boton2.text = "muevete con los botones de (wasd) o joystick pulsa (espacio) o (a) para avanzar";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 1)
		{
			boton2.text = "wasd o joystick para moverse pulsa (espacio) o (a) para saltar";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 2)
		{
			boton2.text = "press and hold (space) or (a) to glide";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 3)
		{
			boton2.text = "press (a) and (d) or joystick to move laterally press (right click) or (b) to change perspective and (space) or (a) to jump";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 4)
		{
			boton2.text = "tap the speed up tiles to increase the length of the jumps";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 8)
		{
			boton2.text = "wasd or joystick to move, press (space) or (a) to accelerate press (right click) or (b) to go back, grab the accelerators to go faster stay on 1 to win";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 9)
		{
			boton2.text = "wasd or joystick to move, press (space) or (a) to accelerate press (right click) or (b) to go back, grab the accelerators to go faster avoid the obstacles, stay on 1 to win";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 10)
		{
			boton2.text = "squeeze space on top of a jumper to get higherapreta espacio encima de un saltador para llegar mas alto";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 11)
		{
			boton2.text = "wasd or joystick to move, press (space) or (a) to accelerate press (right click) or (b) to go back, grab the accelerators to go faster dodge the obstacles and stay on 1 to win speed up the jumper to climb the rock";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(tuto == 12)
		{
			boton2.text = "wasd or joystick to move and press (space) or (a) to jump touch the enemy ship to win and don't forget to grab the speed coins to launch the vendor ship";
			boton1.text = "Press (space) or (a) to continue";
		}
		if(estados == 1)
		{
			boton1.text = "press (right click) or (b) to go up to ship";
		}
		if(estados == 2)
		{
			boton1.text = "press (right click) or (b) to get on the elevator";
		}
		if(estados == 3)
		{
			boton1.text = "(left click) or (x) to go down the floor";
			boton2.text = "time";
		}
		if(estados == 4)
		{
			boton1.text = "KING'S ROOM";
		}
		if(estados == 5)
		{
			boton1.text = "SECRET ROOM";
		}
		if(menu == 1)
		{
			boton1.text = "delete data";
			boton2.text = "settings";
			boton3.text = "start adventure";
		}
		if(menu == -1)
		{
			boton1.text = "presents";
		}
		if(menu == -2)
		{
			boton1.text = "skip";
		}
		if(menu == 2)
		{
			boton1.text = "you're sure?";
			boton2.text = "delete data";
			boton3.text = "Go back";
		}
		if(menu == 3)
		{
			boton1.text = "controls";
			boton2.text = "keyboard and mouse or controller";
			boton3.text = "touch controls";
			boton4.text = "language";
		}
		if(menu == 4)
		{
			boton1.text = "the end";
			boton2.text = "back to menu";

		}
		if(menu == 5)
		{
			boton1.text = "controls";
			boton2.text = "pc or console";
			boton3.text = "touch device";
			boton4.text = "what device are you playing on?";
			boton5.text = "if you are playing on a tablet or android pc select touch device if you are on the above devices with a controller or on pc or console select pc or console";
			boton6.text = "once selected to change it go to settings";
		}
		if (this.juego == 0 && this.piso == 1 && jugador.dentrotienda == true)
		{
			this.cuentamonedas.text = "coins:  " + this.monedas;
			this.cuentagemas.text = "gems:  " + this.gemas;
			this.cuentafrag.text = "special gem fragments: " + this.fragmento + "/3";

		}
		if (this.juego == 0 && this.piso == 1 && jugador.dentrotienda == false || this.juego == 0 && this.piso == 2 && jugador.dentrotienda == false|| this.juego == 0 && this.piso == 3 && jugador.dentrotienda == false|| this.juego == 0 && this.piso == 4 && jugador.dentrotienda == false)
		{
			this.cuentamonedas.text = "coins:  " + this.monedas;
			this.cuentagemas.text = "gems:  " + this.gemas;
			this.cuentafrag.text = "special gem fragments: " + this.fragmento + "/3";

			if (gemas == 0)
			{
				this.mision.text = "MISSION: Go through a door and get a gem by completing a level";
			}
			if (gemas == 1 && monedas < 10)
			{
				this.mision.text = "MISSION: do the remaining 2 levels and go downstairs and get 10 coins";
			}
			if (gemas == 2 && monedas < 10)
			{
				this.mision.text = "MISSION: do the level you have left and go down below and get 10 coins";
			}
			if (gemas == 3 && monedas < 10)
			{
				this.mision.text = "MISSION: go downstairs and get 10 coins";
			}
			if (gemas == 1 && monedas == 10)
			{
				this.mision.text = "MISSION: do the remaining 2 levels";
			}
			if (gemas == 2 && monedas == 10)
			{
				this.mision.text = "MISSION: do the level you have left";
			}
			if (gemas == 3 && monedas == 10 && tengovel == 0)
			{
				this.mision.text = "MISSION: go to the shop on the first floor and pick up the accelerator";
			}
			if (gemas <= 6 && monedas <= 20 && tengovel == 1)
			{
				this.mision.text = "MISSION: go up to the second floor and get 6 gems go down to space and reach 20 coins using the accelerator";
			}
			if (gemas == 6 && monedas == 20 && tengocoche == 0)
			{
				this.mision.text = "MISSION: go to the store and pick up your new car";
			}
			if (gemas <= 9 && monedas <= 30 && tengocoche == 1)
			{
				this.mision.text = "MISSION: go up to the third floor and get 9 gems go down to space and reach 30 coins using the car to use it touch it";
			}
			if (gemas == 9 && monedas == 30 && tengosalto == 0)
			{
				this.mision.text = "MISSION: go to the store and pick up the jumper";
			}
			if (gemas <= 12 && monedas <= 40 && tengosalto == 1)
			{
				this.mision.text = "MISSION: go up to the fourth floor and get 12 gems go down to space and reach 40 coins using the jumper";
			}
			if (gemas == 12 && monedas == 40 && tengonave == 0)
			{
				this.mision.text = "MISSION: go to the store and pick up the spaceship";
			}
			if (gemas == 12 && monedas == 40 && tengonave == 1)
			{
				this.mision.text = "MISSION phase 1: use the spaceship on your property by touching it in the free zone and travel to asteroids and reach all 13 gems";
			}
			if (gemas == 13 && tengonave == 1 && tengollave1 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floor 2";
			}
			if (gemas == 13 &&  tengonave == 1 && tengollave1 == 1 && tengollave2 == 0 && tengollave3 == 0)
			{
				this.mision.text = "MISSION phase 1: use the spaceship on your property by touching it in the free zone and travel to asteroids and reach 14 gems";
			}
			if (gemas == 14 && tengonave == 1 && tengollave1 == 1 && tengollave2 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floor 3";
			}
			if (gemas == 14 &&  tengonave == 1 && tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0)
			{
				this.mision.text = "MISSION phase 1: use the spaceship on your property by touching it in the free zone and travel to asteroids and reach 15 gems";
			}
			if (gemas == 15 && tengonave == 1 && tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floor 4";
			}
			if (gemas == 14 && tengonave == 1 && tengollave1 == 0 && tengollave2 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floor 2 and 3";
			}
			if (gemas == 15 && tengonave == 1 && tengollave1 == 0 && tengollave2 == 0 && tengollave3 == 0)
			{
				this.mision.text = "MISSION phase 1: go to the store and collect the secret key to the mines on floors 2, 3 and 4";
			}
			if (tengollave1 == 1 && tengollave2 == 0 && tengollave3 == 0 && fragmento == 0)
			{
				this.mision2.text = "MISSION phase 2: go to the second floor and get a large gem fragment in the secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2 and 3 and get a large gem fragment in their respective secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2, 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 1)
			{
				this.mision2.text = "MISSION phase 2: go to the second floor and get a large gem fragment in the secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 1 && fragmentoN1 == 1 && fragmentoN2 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to the third floor and get a large gem fragment in the secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 0 && fragmentoN1 == 0 && fragmentoN2 == 0 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2, 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 1 && fragmentoN2 == 0 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 3 and 4 and get a large gem fragment in their respective secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 1 && fragmentoN2 == 1 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to the fourth floor and get a large gem fragment in the secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 0 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2 and 3 and get a large gem fragment in their respective secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 0 && fragmentoN2 == 1 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISSION phase 2: go to the second floor and get a large gem fragment in the secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 1 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISSION phase 2: go to floor 2 and 4 and get a large gem fragment in their respective secret level";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 1 && fragmentoN2 == 0 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISSION phase 2: go to the third floor and get a large gem fragment in the secret level";
			}
			if (fragmento == 3 && monedas < 50 && tengollave4 == 0)
			{
				this.mision.text = "MISSION phase 3: get 50 coins for space";
			}
			if (fragmento == 3 && monedas == 50 && tengollave4 == 0)
			{
				this.mision.text = "MISSION phase 3: go to the store and collect the key to the fifth floor";
			}

			if (fragmento == 3 && tengollave4 == 1 && tengomejora == 0)
			{
				this.mision.text = "MISSION phase 3: Pick up the hyperdrive on the fifth floor";
			}
			if (fragmento == 3 && tengomejora == 1)
			{
				this.mision.text = "MISSION final phase: go to space with the ship and get out of this galaxy you have unlocked the tower of time go up to the fifth floor and beat your records";
			}
			

			
		}
		if (piso == 5 && tengomejora == 1)
		{
			this.mision.text = "MISSION final phase: go to space with the ship and get out of this galaxy you have unlocked the tower of time go up to the fifth floor and beat your recordss";
		}
		if (this.juego == 4 && this.piso == 10 || this.juego == 1 && this.piso == 10 || this.juego == 4 && this.piso == 1)
		{
			this.cuentamonedas.text = "coins:  " + this.monedas;
		}
				if (this.juego == 4 && this.piso == 10 && this.mundos == true || this.juego == 1 && this.piso == 10 && this.mundos == true || this.juego == 4 && this.piso == 1 && this.mundos == true )
		{
			this.cuentagemas.text = "gems:  " + this.gemas;
		}
		if (juego == 6 && tengomejora == 1)
		{
			this.mision.text = "MISSION final phase: fly up to the landing platform and get out of this galaxy";
		}
		}
	if(idioma == "cat")
	{
		if(tuto == -2)
		{
			boton2.text = "Et Pots moure amb (wasd) o joystick";
			boton3.text = "pren (x) o click esquerre per pujar i pren (b) o click dret  per baixar el ascensor";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == -1)
		{
			boton2.text = "Et Pots moure amb (wasd) o joystick pren (espai) o (a) per avancar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 1)
		{
			boton2.text = "wasd o joystick per moure's pren (espai) o (a) per saltar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 2)
		{
			boton2.text = "pren i manteneix (espai) o (a) per planejar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 3)
		{
			boton2.text = "pren (a) y (d) o joystick per desplacarte lateralment pren (click dret) o (b) per canviar de prespectiva y (espaio) o (a) per saltar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 4)
		{
			boton2.text = "toca les fitxes aceleradores per aumentar la logitud de dels saltos";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 8)
		{
			boton2.text = "wasd o joystick per moure's, pren (espai) o (a) per acelerar pren (click dret) o (b) per anar atras,agafa els aceleradors per anar mes rapid arriba lloc 1 per guanyar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 9)
		{
			boton2.text = "wasd o joystick per moure's, pren (espai) o (a) per acelerar pren (click dret) o (b) per anar atras,agafa els aceleradors per anar mes rapid esquiva els obstacles, queda lloc 1 per guanyar";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 10)
		{
			boton2.text = "pren (espai) a sobre d un saltador per arribar molt alt";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 11)
		{
			boton2.text = "wasd o joystick per moures, pren (espai) o (a) per acelerar pren (click dret) o (b) per anar atras,agafa els aceleradors per anar mes rapid esquiva els obstacles y arriba al lloc 1 per guanyar acelera al saltador per putjtar a la pedra";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(tuto == 12)
		{
			boton2.text = "wasd o joystick para moverse ypulsa (espacio) o (a) para saltar toca la nave enemiga para ganary no te olvides de agarrar las monedas de velocidad para alanzar al la nave de vendedor";
			boton1.text = "pren (espai) o (a) per continuar";
		}
		if(estados == 1)
		{
			boton1.text = "pren (click dret) o (b) per putjar a la nau";
		}
		if(estados == 2)
		{
			boton1.text = "pren (click dret) o (b) per putjar al ascensor";
		}
		if(estados == 3)
		{
			boton1.text = "(click esquerre) o (x) per baixar de planta";
			boton2.text = "tiempos";
		}
		if(estados == 4)
		{
			boton1.text = "SALA D EL REY";
		}
		if(estados == 5)
		{
			boton1.text = "SALA SECRETA";
		}
		if(menu == 1)
		{
			boton1.text = "Esborra data";
			boton2.text = "opcions";
			boton3.text = "comencar joc";
		}
		if(menu == -1)
		{
			boton1.text = "presenta";
		}
		if(menu == -2)
		{
			boton1.text = "saltar";
		}
		if(menu == 2)
		{
			boton1.text = "estas segur?";
			boton2.text = "esborra data";
			boton3.text = "tornar andarrere";
		}
		if(menu == 3)
		{
			boton1.text = "controls";
			boton2.text = "teclat y ratoli o control";
			boton3.text = "tactil (sol android)";
			boton4.text = "idioma";
		}
		if(menu == 4)
		{
			boton1.text = "FI";
			boton2.text = "tornar al menu";

		}
		if(menu == 5)
		{
			boton1.text = "controls";
			boton2.text = "pc o consola";
			boton3.text = "dispositiu tactil";
			boton4.text = "en quin dispositiu estas jugan?";
			boton5.text = "si estas jugan a un pc tableta o android selecciona dispositiu tactil si estas als anteriors dispositius amb un control o a un pc o consola selecciona pc o consola";
			boton6.text = "una vez selecionado para cambiarlo entra a opciones";
		}
		if (this.juego == 0 && this.piso == 1 && jugador.dentrotienda == true)
		{
			this.cuentamonedas.text = "diners:  " + this.monedas;
			this.cuentagemas.text = "gemmes:  " + this.gemas;
			this.cuentafrag.text = "fragments de gran gemme: " + this.fragmento + "/3";

		}
		if (this.juego == 0 && this.piso == 1 && jugador.dentrotienda == false || this.juego == 0 && this.piso == 2 && jugador.dentrotienda == false|| this.juego == 0 && this.piso == 3 && jugador.dentrotienda == false|| this.juego == 0 && this.piso == 4 && jugador.dentrotienda == false)
		{
			this.cuentamonedas.text = "diners:  " + this.monedas;
			this.cuentagemas.text = "gemmes:  " + this.gemas;
			this.cuentafrag.text = "fragments de gran gemme: " + this.fragmento + "/3";

			if (gemas == 0)
			{
				this.mision.text = "MISIO: creua una porta i consegueix una gema completan un nivell";
			}
			if (gemas == 1 && monedas < 10)
			{
				this.mision.text = "MISIO: fes els 2 niveles que queden i baixa abaix i agafa 10 monedes";
			}
			if (gemas == 2 && monedas < 10)
			{
				this.mision.text = "MISIO: fes el nivell que et queda i baixa abaix i agafa 10 monedes";
			}
			if (gemas == 3 && monedas < 10)
			{
				this.mision.text = "MISIO: baixa abaix i agafa 10 monedes";
			}
			if (gemas == 1 && monedas == 10)
			{
				this.mision.text = "MISIO: fes els 2 niveles que queden";
			}
			if (gemas == 2 && monedas == 10)
			{
				this.mision.text = "MISIO: fes el nivell que et queda";
			}
			if (gemas == 3 && monedas == 10 && tengovel == 0)
			{
				this.mision.text = "MISIO: ves a la tenda del primer  pis i agafa el acelerador";
			}
			if (gemas <= 6 && monedas <= 20 && tengovel == 1)
			{
				this.mision.text = "MISIO: puja al segon pis i agafa 6 gemmes  baixa al espai y arriba a les 20 monedes fent servir el acelerador";
			}
			if (gemas == 6 && monedas == 20 && tengocoche == 0)
			{
				this.mision.text = "MISIO: ves a la tenda i agafa el teu nuo cotxe";
			}
			if (gemas <= 9 && monedas <= 30 && tengocoche == 1)
			{
				this.mision.text = "MISIO: puja al tercer pis i agafa 9 gemmes                                                     baixa al espai y arriba a les 30 monedes fent servir el cotxe per ferlo servir tocal";
			}
			if (gemas == 9 && monedas == 30 && tengosalto == 0)
			{
				this.mision.text = "MISIO: ves a la tenda y agafa el saltador";
			}
			if (gemas <= 12 && monedas <= 40 && tengosalto == 1)
			{
				this.mision.text = "MISIO: puja al quart pis i agafa 12 gemmes                                                    baixa al espai i arriba a les 40 monedes fent servir el saltador";
			}
			if (gemas == 12 && monedas == 40 && tengonave == 0)
			{
				this.mision.text = "MISIO: ves a la tenda y agafa la nau espacial";
			}
			if (gemas == 12 && monedas == 40 && tengonave == 1)
			{
				this.mision.text = "MISIO fase 1: fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 13 gemmes";
			}
			if (gemas == 13 && tengonave == 1 && tengollave1 == 0)
			{
				this.mision.text = "MISIO fase 1: ves a la tenda y recull la clau secreta de les mines del pis 2 ";
			}
			if (gemas == 13 &&  tengonave == 1 && tengollave1 == 1 && tengollave2 == 0 && tengollave3 == 0)
			{
				this.mision.text = "MISIO fase 1: fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 14 gemmes";
			}
			if (gemas == 14 && tengonave == 1 && tengollave1 == 1 && tengollave2 == 0)
			{
				this.mision.text = "MISIO fase 1: ves a la tenda i recull la clau secreta de les mines del pis 3";
			}
			if (gemas == 14 &&  tengonave == 1 && tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0)
			{
				this.mision.text = "MISIO fase 1: fes servir la nau espacial tocanla al espai i viatja als asteroides i arriba a les 15 gemmes";
			}
			if (gemas == 15 && tengonave == 1 && tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0)
			{
				this.mision.text = "MISIO fase 1: ves a la tenda i recull la clau secreta de les mines del pis 4 ";
			}
			if (gemas == 14 && tengonave == 1 && tengollave1 == 0 && tengollave2 == 0)
			{
				this.mision.text = "MISIO fase 1:ves a la tenda i recull la clau secreta de les mines del pis 2 i 4 ";
			}
			if (gemas == 15 && tengonave == 1 && tengollave1 == 0 && tengollave2 == 0 && tengollave3 == 0)
			{
				this.mision.text = "MISIO fase 1: ves a la tenda i recull la clau secreta de les mines del pis 2,3 i 4";
			}
			if (tengollave1 == 1 && tengollave2 == 0 && tengollave3 == 0 && fragmento == 0)
			{
				this.mision2.text = "MISIO fase 2: s al segon pis i agafa un fragment de gran gemmme en el nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2 i 3 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2, 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 1)
			{
				this.mision2.text = "MISIO fase 2: ves al segon pis y agafa el fragment de gran gemme en el nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 1 && fragmentoN1 == 1 && fragmentoN2 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al tercer pis y agafa el fragment de gran gemme en el nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 0 && fragmentoN1 == 0 && fragmentoN2 == 0 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2, 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 1 && fragmentoN2 == 0 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 3 i 4 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 1 && fragmentoN2 == 1 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al quart pis i agafa un fragment de gran gemmme en el nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 0 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2 i 3 i agafa un fragment de gran gemme al seu respectiu nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 0 && fragmentoN2 == 1 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISIO fase 2: ves al seguon pis i agafa un fragment de gran gemme en el nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 1 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISIO fase 2: ves al pis 2 y 4 i agafa un fragment de gran gemme en el seu respectiu nivell secret";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 1 && fragmentoN2 == 0 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISIO fase 2: ves al tercer pis y agafa un fragment de gran gemme en el nivell secret";
			}
			if (fragmento == 3 && monedas < 50 && tengollave4 == 0)
			{
				this.mision.text = "MISIO fase 3: agafa 50 monedes en el espai amb la nau";
			}
			if (fragmento == 3 && monedas == 50 && tengollave4 == 0)
			{
				this.mision.text = "MISIO fase 3: ves a la tenda i agafa la calu del cinque pis";
			}

			if (fragmento == 3 && tengollave4 == 1 && tengomejora == 0)
			{
				this.mision.text = "MISIO fase 3: recull el hiperpropulsor en el cinque pis";
			}
			if (fragmento == 3 && tengomejora == 1)
			{
				this.mision.text = "MISIO fase final: ves al espaci amb la nau i vesten d aquesta galaxia                 has desbloquejat la torre del temps puja a d alt del cinque pis y supera els records negatius";
			}
			

			
		}
		if (piso == 5 && tengomejora == 1)
		{
			this.mision.text = "MISIO fase final: ves al espai amb la nau y vesten de aquesta galaxia                 has desbloquejat la torre del temps puja a d alt del cinque pis y supera els records negatius";
		}
		if (this.juego == 4 && this.piso == 10 || this.juego == 1 && this.piso == 10 || this.juego == 4 && this.piso == 1)
		{
			this.cuentamonedas.text = "diners:  " + this.monedas;
		}
				if (this.juego == 4 && this.piso == 10 && this.mundos == true || this.juego == 1 && this.piso == 10 && this.mundos == true || this.juego == 4 && this.piso == 1 && this.mundos == true )
		{
			this.cuentagemas.text = "gemmes:  " + this.gemas;
		}
		if (juego == 6 && tengomejora == 1)
		{
			this.mision.text = "MISION fase final: vola a d alt d la plataforma de aterricaje y surt d aquesta galaxia";
		}
		}


		if(mejora1 == 0 && gemas >= 3 && monedas >= 10)
		{
			PlayerPrefs.SetInt("mejorac1", 1);
			SceneManager.LoadScene("mejora1");
		}
		if(mejora2 == 0 && gemas >= 6 && monedas >= 20)
		{
			PlayerPrefs.SetInt("mejorac2", 1);
			SceneManager.LoadScene("mejora2");
		}
		if(mejora3 == 0 && gemas >= 9 && monedas >= 30)
		{
			PlayerPrefs.SetInt("mejorac3", 1);
			SceneManager.LoadScene("mejora3");
		}
		if(mejora4 == 0 && gemas >= 12 && monedas >= 40)
		{
			PlayerPrefs.SetInt("mejorac4", 1);
			SceneManager.LoadScene("mejora4");
		}
		if(mejora5 == 0 && fragmento >= 3 && monedas >= 50)
		{
			PlayerPrefs.SetInt("mejorac5", 1);
			SceneManager.LoadScene("mejora5");
		}

	}


}
