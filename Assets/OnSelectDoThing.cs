using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelectDoThing : MonoBehaviour
{
    public List<Transform> Keyframes = new List<Transform>();
    
    public Vector3 Velocity = Vector3.zero;
    
    int CurrentKeyframe = 0;
    bool animate = false;
    // Start is called before the first frame update
    void Start()
    {
        //Velocity += (targetPos - currentPos) * spring;
        //Velocity -= drag * velocity;
        //CurrentPos += Velocity
    }

    public void OnSelect()
    {
        animate = true;
        Velocity = Vector3.zero;
        CurrentKeyframe = 0;
        transform.position = Keyframes[CurrentKeyframe].position;
        transform.rotation = Keyframes[CurrentKeyframe].rotation;
        transform.localScale = Keyframes[CurrentKeyframe].localScale;
    }
    void Update()
    {
       int lol = 0;
       
    }


}
