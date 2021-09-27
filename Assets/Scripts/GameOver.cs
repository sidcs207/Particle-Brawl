using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;

    private Text text;
    void Start()
    {
        text = GetComponent<Text>();

        text.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Player==null){
            text.color = new Color(0, 0, 0, 1);
			text.text = "       Game Over\nPress Space to Restart";
			
			// jump is space bar by default
			if (Input.GetButtonDown("Jump"))
            {
               charactermovement.health=120;
               Score.total++;
           SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
