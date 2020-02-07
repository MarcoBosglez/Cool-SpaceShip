using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 5);

        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);

        Renderer rd = GetComponent<Renderer>();
        rd.material.color = newColor;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * 2;
    }

}
