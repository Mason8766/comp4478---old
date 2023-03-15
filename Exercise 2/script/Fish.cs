using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    // Start is called before the first frame update

    //scripts
    public bomb other;
    public score other2;

    public static int flag = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag != 2){//if game hasnt ended
            if (transform.position.y > -5)  //if fish is in the correct postion, move the fish down
                transform.Translate(0.0f, -0.01f, 0f);  
            else//fish needs to be reset
                transform.position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(10.0f, 20.0f), 1.0f);

          
            if (transform.position.y >18 && flag == 0) //This will mean a bomb is selected
            {
                flag = 1;
            }
            if (flag == 1) //if bomb is selected, move the fish postion, and start the bomb
            {
                transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 17, 1.0f);    
                bomb.startBomb();
            }
        }

    }
    //flag indicators 
    public static void stopBomb(){
        flag = 0;
     
    }
    public static void EndFish(){
        flag = 2;
    }
        
    public  void OnTriggerEnter2D(Collider2D collision){//if fish collides with net
                if(flag  != 2 && transform.position.y < 7 && transform.position.y > -7){//if fish is in the right postion
                //Move the fish
                transform.position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(10.0f, 20.0f), 1.0f);   //move fish back to the top
          
                   score.AddScore(); //add the score
             
                }
          }
          
}
