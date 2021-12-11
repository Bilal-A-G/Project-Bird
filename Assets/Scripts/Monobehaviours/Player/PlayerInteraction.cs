using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour, IInteractable
{
    bool isHoveringOver;
    GameObject currentHoverObject;

    public void HoverOver(GameObject hoverObject)
    {
        if(hoverObject != null && hoverObject.GetComponent<ITouchable>() != null || hoverObject == currentHoverObject)
        {
            isHoveringOver = true;
            currentHoverObject = hoverObject;
        }
        else if(currentHoverObject != null)
        {
            isHoveringOver = false;
            currentHoverObject = null;
        }

        if (isHoveringOver && currentHoverObject != null)
        {
            Debug.Log("Hovering over " + currentHoverObject.transform.name);
        }
    }

    public void Interact(GameObject interactObject)
    {
        if (interactObject != null && interactObject.GetComponent<ITouchable>() != null)
        {
            interactObject.GetComponent<ITouchable>().Touch(gameObject);
        }
    }
}
