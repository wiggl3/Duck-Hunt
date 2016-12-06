using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TelaSurvival : MonoBehaviour {

    [SerializeField]
    GameObject Options;
    bool pause = false;

    Tiro option;



	// Use this for initialization
	void Start () {
        option = FindObjectOfType<Tiro>();
	}
	
	// Update is called once per frame
	void Update () {

        if (pause == true)
        {
            Time.timeScale = 0;
        }

        if (pause == false)
        {
            Time.timeScale = 1;
        }

        if (option.menu == false)
        {
            Options.SetActive(false);
            pause = false;
        }

        if (option.menu == true)
        {
            Options.SetActive(true);
            pause = true;
        }

        if (option.corPatos == 10)
        {
            option.menu = true;
        }
       
	
	}

     public void survival()
        {
            pause = false;
            option.menu = false;
            option.corPatos += 1;
        }

     public void End()
     {
         SceneManager.LoadScene("GameOver");
     }

}
