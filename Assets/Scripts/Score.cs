using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
   private Text text;
   public static  int score=0;
   public static int total=0; 
   private GameObject sound;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame

     void Update(){
         text.text="Kills "+score;
         if(score==100)
         {
             score=0;
             sound = GameObject.Find("audiosource");
            Destroy(sound);
            SceneManager.LoadScene("YouWin");

         }
    }
}
