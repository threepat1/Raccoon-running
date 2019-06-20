using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateCollide : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    
        if (collision.gameObject.tag == "Player")
        {
            Player.health -= 1;
            Destroy(gameObject, 0.2f);
        }
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag =="Coin")
        {
            Destroy(gameObject);
            print("What");
            if(collision.gameObject.tag == "Player")
            {
                gameObject.SetActive(false);
            }
        }
    }
 
}
