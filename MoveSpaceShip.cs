using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpaceShip : MonoBehaviour {



    public GameObject Bala;

    public AudioSource audioSource;
    public AudioSource effect;
    AudioClip Pew;


    private void Start()
    {
        Pew = Resources.Load<AudioClip>("Pew");

        effect = GetComponent<AudioSource>();

        Destroy(gameObject, 3);
    }
   

    void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0);
        }


            if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * 0.2f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * 0.2f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.up * 0.2f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.down * 0.2f);
        }


        // BALA

        if (Input.GetKeyDown(KeyCode.O))
        {
            GameObject b = (GameObject)(Instantiate(Bala, transform.position + transform.up * 2.0f, Quaternion.identity));

            b.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);

            effect.PlayOneShot(Pew, 0.20f);




            Vector3 viewPortPosition = Camera.main.WorldToViewportPoint(transform.position);
            Vector3 viewPortXDelta = Camera.main.WorldToViewportPoint(transform.position + Vector3.left / 2);
            Vector3 viewPortYDelta = Camera.main.WorldToViewportPoint(transform.position + Vector3.up / 2);

            float deltaX = viewPortPosition.x - viewPortXDelta.x;
            float deltaY = -viewPortPosition.y + viewPortYDelta.y;
            viewPortPosition.x = Mathf.Clamp(viewPortPosition.x, 0 + deltaX, 1 - deltaX);
            viewPortPosition.y = Mathf.Clamp(viewPortPosition.y, 0 + deltaY, 1 - deltaY);
            transform.position = Camera.main.ViewportToWorldPoint(viewPortPosition);
        }
    }
}
