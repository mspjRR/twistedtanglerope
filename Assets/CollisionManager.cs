using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject redball1;
    public GameObject redball2;
    public GameObject redballthread; 
    public GameObject blueball1;
    public GameObject blueball2;
    public GameObject blueballthread;  
    public GameObject Greenball1;
    public GameObject GreenBall2;
    public GameObject GreenballThread;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Redball")
        {
            redball1.SetActive(false);
            redball2.SetActive(false);
            redballthread.SetActive(false);
        }
        if (collision.gameObject.tag=="Greenball")
        {
            Debug.Log("working");
            blueball1.SetActive(false);
            blueball2.SetActive(false);
            blueballthread.SetActive(false);
            Greenball1.SetActive(false);
            GreenBall2.SetActive(false);
            GreenballThread.SetActive(false);

        }


    }

   

}
