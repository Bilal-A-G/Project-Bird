using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTouched : MonoBehaviour, ITouchable
{
    public void Touch(GameObject touchingObject)
    {
        Debug.Log(touchingObject.transform.name + " touched me");
    }
}
