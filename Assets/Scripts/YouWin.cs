using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{


    private Text text;
    void Start()
    {
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
			text.text = "  You Win\n\nTotal Attempts: "+Score.total+"\n\nPress Enter";	
              charactermovement.health=120;
              if (Input.GetAxis("Submit") == 1)
		{    
            Score.total=0;
           SceneManager.LoadScene("TitleScene");
        }
    }
}
