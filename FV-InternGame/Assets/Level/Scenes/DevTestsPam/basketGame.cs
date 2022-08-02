using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketGame : MonoBehaviour
{
    public GameHandler gameHandlerObj;
    public AudioSource hoop;
    public AudioClip green;
    public AudioClip yellow;
    public AudioClip red;
    
    private GameObject needle;
    private GameObject meter;
    private GameObject ball;
    
    // Use this for initialization
    public float speed = 1;
    public float RotAngleZ = 180;
    
    private float rZ;
    private bool hasStopped = false;
    private Animator animator;
    
    // Start is called before the first frame update
    
    void Awake()
    {
        needle = GameObject.Find("needle");
        meter = GameObject.Find("meter");
        ball = GameObject.Find("ball");
        
    }
    
    void Start()
    {
        if (GameObject.FindWithTag("GameController") != null){
              gameHandlerObj = GameObject.FindWithTag("GameController").GetComponent<GameHandler>();
         }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameHandlerObj.tryCount <= 0) {
            //print("The Game has ENDED");
            hasStopped = true;
            //ball.SetActive(false);
            
        } else {
            if (Input.GetKeyDown("space") && !hasStopped) {
                print("space bar was pressed");
                hasStopped = true;
                determineColor(rZ);
            }
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
            StartCoroutine(delayAudio("red"));
            nextTurn();
            
        /* YELLOW range */
        } else if ( (angle >= 27 && angle < 76) || (angle > 102) && (angle <= 152) ) {
            //print("Yellow!");
            if (luckyShot()) {
                //set to green
                animator.SetInteger("color", 3);
                StartCoroutine(resetAnimation());
                StartCoroutine(delayAudio("green"));
            } else {
                //missed the lucky shot
                animator.SetInteger("color", 2);
                StartCoroutine(resetAnimation());
                StartCoroutine(delayAudio("yellow"));
            }
            
        /* GREEN range*/
        } else if ( angle >= 76 && angle <= 102) {
            //print("Green!");
            animator.SetInteger("color", 3);
            incrementPoint();
            StartCoroutine(resetAnimation());
            StartCoroutine(delayAudio("green"));
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
    
    IEnumerator delayAudio(string color)
    {
        yield return new WaitForSeconds(1f);
        if (color == "red") {
            hoop.PlayOneShot(red, 1f);
        } else if (color == "yellow") {
            hoop.PlayOneShot(yellow, 1f);
        } else if (color == "green") {
            hoop.PlayOneShot(green, 1f);
        } else {
            print("unknown color");
        }
    }
    
    bool luckyShot()
    {
        int randomNumber = Random.Range(0, 10);
        bool madeShot = true;
        
        if (randomNumber > 6) {
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
        gameHandlerObj.AddScore(1);
        nextTurn();
    }
    
    void nextTurn()
    {
        gameHandlerObj.DecrementTries();
    }
}
