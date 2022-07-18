using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basketGame : MonoBehaviour
{
    private GameObject needle;
    private GameObject meter;
    private GameObject ball;
    
    // Use this for initialization
    public float speed = 1;
    public float RotAngleZ = 180;
    
    private float rZ;
    private bool hasStopped = false;
    private Animator animator;
    
    //UI
    public int pointsCount = 0;
    public int throwsCount;
    public GameObject pointsText;
    public GameObject throwsText;
     
    // Start is called before the first frame update
    
    void Awake()
    {
        needle = GameObject.Find("needle");
        meter = GameObject.Find("meter");
        ball = GameObject.Find("ball");
        
    }
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && !hasStopped && throwsCount > 0) {
            print("space bar was pressed");
            hasStopped = true;
            determineColor(rZ);
        }
        
        if (throwsCount == 0) {
            print("The Game has ENDED");
        }
    }
    
    void FixedUpdate()
    {
        if (!hasStopped) {
            rZ = Mathf.SmoothStep(0,RotAngleZ,Mathf.PingPong(Time.time * speed,1));
            needle.transform.rotation = Quaternion.Euler(0,0,rZ);
        }
        
        
    }
    
    void determineColor(float angle)
    {
        animator = ball.GetComponent<Animator>();
        
        /* RED range */
        if (angle < 27 || angle > 152) {
            //print("Red!");
            animator.SetInteger("color", 1);
            StartCoroutine(resetAnimation());
            nextTurn();
        /* YELLOW range */
        } else if ( (angle >= 27 && angle < 76) || (angle > 102) && (angle <= 152) ) {
            //print("Yellow!");
            if (luckyShot()) {
                //set to green
                animator.SetInteger("color", 3);
                StartCoroutine(resetAnimation());
            } else {
                //missed the lucky shot
                animator.SetInteger("color", 2);
                StartCoroutine(resetAnimation());
            }
            
        /* GREEN range*/
        } else if( angle >= 76 && angle <= 102) {
            //print("Green!");
            animator.SetInteger("color", 3);
            incrementPoint();
            StartCoroutine(resetAnimation());
        } else {
            print("ERROR: Unknown Color");
        }
    }
    
    IEnumerator resetAnimation()
    {
        yield return new WaitForSeconds(4);
        animator.SetInteger("color", 0);
        hasStopped = false;
    }
    
    bool luckyShot()
    {
        int randomNumber = Random.Range(0, 10);
        bool madeShot = true;
        
        if (randomNumber > 7) {
            print("LUCKY SHOT!!!");
            incrementPoint();
            madeShot = true;
            return madeShot;
        } else {
            madeShot = false;
            nextTurn();
            return madeShot;
            
        }
    }
    
    void incrementPoint()
    {
        //increast UI points
        pointsCount++;
        Text pointsTextB = pointsText.GetComponent<Text>();
        pointsTextB.text = "Points: " + pointsCount;
        nextTurn();
    }
    
    void nextTurn()
    {
        throwsCount--;
        Text throwsTextB = throwsText.GetComponent<Text>();
        throwsTextB.text = "Num Tries: " + throwsCount;
    }
}
