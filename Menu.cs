using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    [SerializeField]
    Text maxpontos;

	// Use this for initialization
	void Start () 
    {
        maxpontos.text = "High Score - " + PlayerPrefs.GetInt("PONTOS").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Iniciar()
    {
        SceneManager.LoadScene("Dunk Hunt");
    }
    

        public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }

        
}
