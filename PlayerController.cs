using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
    
{
    public GameObject PlayerBulletGO;
    public GameObject BulletPosition01;
    public GameObject BulletPosition02;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGO);
            bullet01.transform.position = BulletPosition01.transform.position;

            GameObject bullet02 = (GameObject)Instantiate(PlayerBulletGO);
            bullet02.transform.position = BulletPosition02.transform.position;

        }

        float horizontal = Input.GetAxisRaw("Horizontal"); // to move object sideward 
        if (horizontal != 0f)
            if (horizontal > 0f)
                transform.Translate (5f * Time.deltaTime, 0f, 0f);
            else
                transform.Translate (-5f * Time.deltaTime, 0f, 0f);

        float vertical = Input.GetAxisRaw ("Vertical"); // to move object upward 
        if (vertical != 0f)
            if (vertical > 0f)
                transform.Translate (0f, 5f * Time.deltaTime, 0f);
            else
                transform.Translate (0f, -5f * Time.deltaTime, 0f);    
    }
}
