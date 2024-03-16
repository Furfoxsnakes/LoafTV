using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public bool IsCompleted { get; protected set; }
    public float StartTime { get; protected set; }

    public float RunTime => Time.time - StartTime;
    
    public virtual void Enter() {
        
    }

    public virtual void Exit() {
        
    }

    public virtual void Do() {
        
    }

    public virtual void FixedDo() {
        
    }
}
