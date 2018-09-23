using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WomanState { Start, Moving, End };

public class WomanScript : MonoBehaviour {

    public WomanState state = WomanState.Start;

    public Transform target;
    public float speed;

    Animator animator;
    
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	void Update () {
        switch (this.state)
        {
            case WomanState.Start:
                this.MoveToFinalPoint();
                this.state = WomanState.Moving;
                break;
            case WomanState.Moving:
                this.MoveToFinalPoint();
                this.CheckForMovingEnd();
                break;
            case WomanState.End:
                break;
        }
    }

    void MoveToFinalPoint ()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    void CheckForMovingEnd()
    {
        if (this.gameObject.transform.position == this.target.position)
        {
            this.state = WomanState.End;
            animator.SetTrigger("Idle");
        }
    }
}
