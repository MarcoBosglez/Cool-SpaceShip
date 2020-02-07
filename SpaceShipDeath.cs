using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShipDeath : MonoBehaviour
{

    int resistencia;
    float colorB, colorG;
    Color colorResistencia;
    SpriteRenderer renderer;

    void Start()
    {
        resistencia = 5;
        colorG = 204.0f;
        colorB = 204.0f;
        colorResistencia = new Color(255, colorG / 255f, colorB / 255f, 1.0f);
        renderer = GetComponent<SpriteRenderer>();

    }

    void Update()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);

            resistencia = resistencia - 1;
            colorB = colorB - 51;
            colorG = colorG - 51;

            colorResistencia = new Color(255, colorG / 255f, colorB / 255f, 1.0f);
            renderer.color = colorResistencia;
            if (resistencia < 1)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
