using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
	
    public GameObject[] passaros;

	Tiro spa;

    // Use this for initialization
    void Start()
    {
		spa = GameObject.FindObjectOfType<Tiro> ();
        Instantiate(passaros[Random.Range(0,3)], transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

        if (spa.morte >= 2)
        {
            Instantiate(passaros[Random.Range(0,3)], transform.position, Quaternion.identity);
        }
    }




}
