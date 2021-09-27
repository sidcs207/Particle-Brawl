using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowdownfactor=0.05f;
    public float slowdownlength=2f;

    void Update()
    {
        Time.timeScale+=(1f/slowdownlength)*Time.unscaledDeltaTime;
        Time.timeScale=Mathf.Clamp(Time.timeScale,0f,1f);
        if(Time.timeScale==1.0f){
            Time.fixedDeltaTime=Time.deltaTime;
        }
    }
     public void SlowMotion()
    {
        Time.timeScale=slowdownfactor;
        Time.fixedDeltaTime=Time.timeScale*.02f;
    
    }
}
