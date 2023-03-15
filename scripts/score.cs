using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
   public Movement other; //script
   static private TextMeshProUGUI text;
   static int flag = 0;
    // Start is called before the first frame update
    static int scoreTotal = 0;
    void Start()
    {
      text = GetComponent<TextMeshProUGUI> (); //sets text to the textbox
      
  
       
    }

    // Update is called once per frame
    void Update()
    {   
        if (flag == 1) //if a fish is scored
        {
            flag = 0;
        scoreTotal = scoreTotal + 1; //add one to the total
        text.text =scoreTotal.ToString();  //update text
        }
        if (flag ==2){//if a bomb is caught by the net
            //end game seqeuence 
            text.text = "GAME OVER";
            text.color = Color.red;
            Movement.endGame();
              
        }
    }

//flag setters
    public static void AddScore(){//caught a fish
        flag = 1;
        }
        public static void endGame(){//caught a bomb
        flag = 2;
        }


        
}
