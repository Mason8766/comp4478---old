using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
   
public class Movement : MonoBehaviour  
{  
       static int flag = 0;
    // Start is called before the first frame update  
    void Start()  
    {  
          
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
        if (flag == 0){ //if the game hasnt ended 
            if (Input.GetKey(KeyCode.A))  
            {  
                transform.Translate(0.01f, 0f, 0f);  //move right
            }  
            if (Input.GetKey(KeyCode.D))  
            {  
                transform.Translate(-0.01f, 0f, 0f);  //move left
            }  
        }else{
                transform.position = new Vector3(-100f, -100f, 1.0f); //move net off screen, including collider
    } 
    } 
    //game is over flag indicator
    public static void endGame(){
        flag = 1;
        
        }
    

}  