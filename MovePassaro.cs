using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]
[RequireComponent(typeof(Animator))]

public class MovePassaro : MonoBehaviour
{
	Animator passaroMove;
    int x;
    int y;
    Rigidbody2D rb;
	public bool atirar = true;


	Tiro points;

    // Use this for initialization
    void Start()
    {
        passaroMove = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D>();
        points = GameObject.FindObjectOfType<Tiro>();

        velocity();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(x*Time.deltaTime, y*Time.deltaTime, 0);
        rb.AddForce(new Vector3(x, y, 0));

        if (points.numBalas < 1)
        {
            atirar = false;
        }
    }

    void velocity()
    {
        x = Random.Range(-2, 2);
        y = Random.Range(1, 2);

        if (x == -1 || x == -2)
        {
            passaroMove.SetInteger("Vel", 1);
            Flip();
        }

        else if (x == 1 || x == 2)
        {
            passaroMove.SetInteger("Vel", 1);
        }

        else if (x == 0)
        {
            passaroMove.SetInteger("Vel", 0);
        }

    }

    void OnMouseDown()
    {
		if (atirar == true) 
		{
			passaroMove.SetInteger ("Vel", 2);
			points.score += 500;
			Destroy (gameObject, 0.3f);
            points.morte += 1;
            points.corPatos += 1;

		}

		if (atirar == false) 
		{
		}
    }

	void Flip()
	{
		Vector3 Scale = GetComponent<Transform>().localScale;
		Scale.x *= -1;
		GetComponent<Transform> ().localScale = Scale;
	}

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.tag == "Parede")
        {
            x *= -1;
            //y *= -1;
            Flip();
        }

        if (outro.gameObject.tag == "Player")
        {
            x *= -1;
            //y *= -1;
            Flip();
        }

        /*if (outro.gameObject.tag == "Teto")
         {
             //x *= -1;
             y *= -1;

         }*/
    }

}
