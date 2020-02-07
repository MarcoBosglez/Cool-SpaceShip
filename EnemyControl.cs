using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {

        speed = 2f;

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 position = transform.position; // obtener posición enemigo
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);// para que aparezcan más enemigos

        transform.position = position;// update a la nueva position

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //limitar los enemigos

        if (transform.position.y <min.y)
        {
            Destroy(gameObject);// si se sale, destruirlo 
            // todo esto solo sirve para que si la nave se sale y no la podamos matar, se destruye
        }

    }
}
