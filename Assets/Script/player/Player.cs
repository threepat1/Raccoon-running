using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isDead;
    public Animator anim;

    public GameObject heart1, heart2, heart3, gameUI, player;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        gameUI.SetActive(false);

        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3) health = 3;
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);  
                break;
        }
        if (health <= 0)
        {

            Death();

        }
    }
    void Death()
    {
        isDead = true;
        gameUI.SetActive(true);
        anim.SetBool("GameOver", true);
        Destroy(player);
    }
}
