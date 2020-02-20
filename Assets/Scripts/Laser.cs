using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    public static float rightx = 35;
    public Text scoreGT;
    
    void Start(){
        GameObject scoreGO=GameObject.Find("Score");
        scoreGT=scoreGO.GetComponent<Text>();
        scoreGT.text="0";
    }

    void Update()
    {
        if(transform.position.x > rightx)
        {
            Destroy(this.gameObject);
        }

    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if( collidedWith.tag == "Object")
        {
            Destroy (collidedWith);
            Destroy(this.gameObject);
            
            int score=int.Parse(scoreGT.text);
            score+=100;
            scoreGT.text=score.ToString();
        
        if	(score	>	HighScore.score)	{	
            HighScore.score	=score;				
        } 
        }
        
                //Add points for cathing the  Apple
              
              
    }
}
