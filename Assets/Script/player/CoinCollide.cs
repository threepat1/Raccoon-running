using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollide : MonoBehaviour
{
    public static int level;
    public int score;
    public int maxscore;
    public Text counter;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScoreText();
        maxscore = 50;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Coin")
        {
            score += 10;
            Destroy(other.gameObject);
            
        }
        SetScoreText();
        
    }
    private void SetScoreText()
    {
        counter.text = "score:" + "\n" +  score.ToString();
    }
    public void LateUpdate()
    {
        if(score >= maxscore)
        {
            level++;
            maxscore += level*30;
        }
    }
}
