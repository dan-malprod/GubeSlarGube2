using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Gube Gube0 = null;
    public Gube Gube1 = null;
    public Gube CurrentlyAttacking = null;
    public Gube NextAttack = null;

    public float StateTimerMax = 1.0f;
    float StateDelta = 0.0f;

    public void Update()
    {
        StateDelta += Time.deltaTime;
        if(StateDelta > StateTimerMax)
        {
            StateDelta = 0.0f;
            if (CurrentlyAttacking != null)
            {
                CurrentlyAttacking = null;
            }
            else
            {
                CurrentlyAttacking = NextAttack;
                if(NextAttack == Gube0)
                {
                    NextAttack = Gube1;
                }
                else
                {
                    NextAttack = Gube1;
                }
            }
        }
    }
}
