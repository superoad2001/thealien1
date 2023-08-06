using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{
    public GameObject juego;
    public GameObject pausa1;
    public int plataforma;
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        player = ReInput.players.GetPlayer(playerID);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetAxis("pausa") > 0 && temp > 0.3f)
        {
            continuar();
        }
        if(temp < 15)
        {temp += 1 * Time.deltaTime;}
    }
    public void continuar(){
        plataforma = PlayerPrefs.GetInt("plataforma", 1);
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        temp = 0;
        juego.SetActive(true);
        pausa1.SetActive(false);
        if(plataforma == 1)
		{
			Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
		}
    }
    public void salir(){
        SceneManager.LoadScene("presentacion");
    }

    public void salirnivel(){
        SceneManager.LoadScene("piso1");
    }
}
