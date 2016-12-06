using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Hit : MonoBehaviour {

	[SerializeField]GameObject[] pontuacao;
    Image teste;

    Tiro spa;
	// Use this for initialization
	void Start () {
        spa = GameObject.FindObjectOfType<Tiro>();
	}
	
	// Update is called once per frame
	void Update () {
        if (spa.corPatos == 1)
        {
            teste = pontuacao[0].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 2)
        {
            teste = pontuacao[1].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 3)
        {
            teste = pontuacao[2].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 4)
        {
            teste = pontuacao[3].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 5)
        {
            teste = pontuacao[4].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 6)
        {
            teste = pontuacao[5].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 7)
        {
            teste = pontuacao[6].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 8)
        {
            teste = pontuacao[7].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 9)
        {
            teste = pontuacao[8].GetComponent<Image>();
            teste.color = Color.red;
        }

        if (spa.corPatos == 10)
        {
            teste = pontuacao[9].GetComponent<Image>();
            teste.color = Color.red;
            spa.menu = true;
        }
	}
}
