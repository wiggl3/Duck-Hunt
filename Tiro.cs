using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tiro : MonoBehaviour
{

	public int score;
    public int numBalas;
    public int morte;
    public int corPatos;
    public bool menu = false;


	[SerializeField] GameObject [] balas;
	[SerializeField] Text scoreTXT;
	[SerializeField] AudioSource shot;

    // Use this for initialization
    void Start()
    {
        numBalas = 3;
        morte = 0;
        corPatos = 0;
        //score = PlayerPrefs.GetInt("PONTOS");
    }

    // Update is called once per frame
    void Update()
    {

		scoreTXT.text = score.ToString ();

        if (Input.GetMouseButtonDown(0))
        {
            numBalas -= 1;
			shot.Play();
        }

		if (numBalas == 3) {
            balas[0].SetActive(true);
            balas[1].SetActive(true);
            balas[2].SetActive(true);
            morte = 0;
		}
			
		if (numBalas == 2)
		{
			balas[0].SetActive (false);
		}

		if (numBalas == 1) 
		{
			balas [1].SetActive (false);
		}

		if (numBalas == 0) 
		{
			balas [2].SetActive (false);
		}

        if (numBalas == -1)
        {
            if (PlayerPrefs.GetInt("PONTOS") < score)
            {
                PlayerPrefs.SetInt("PONTOS", score);
            }
            SceneManager.LoadScene("GameOver");
        }

        if (morte == 2)
        {
            numBalas = 3;
        }

    }
}