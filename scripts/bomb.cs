using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    //Link other scripts
     public Fish other;
     public score other2;

    // Start is called before the first frame update
    public static int flag = 0; //indicator flag


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 1){ //if the bomb is selected, move the bomb
             transform.Translate(0.0f, -0.11f, 0f);  
        }

        if (transform.position.y <-10) //once the bomb is off the screen, reset it and call a new fish
        {
            flag = 0;
            transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 15, 1.0f);
            Fish.stopBomb();
        }

    }
    public static void startBomb(){ //starts the bomb sequence
        flag = 1;
    }
     public  void OnTriggerEnter2D(Collider2D collision){ //if net touches the bomb
            if(transform.position.y < 7 &&  transform.position.y > -7){ //ensures bomb is in correct spot
            transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 15, 1.0f);//move bomb
            flag = 0; 

            //Load the end game seqeuence 
            Fish.EndFish();
            score.endGame();
            }
                   
          }
}
