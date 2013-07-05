using UnityEngine;
using System.Collections;

public class ActionCharacter : MonoBehaviour {

    public ActionTextType _actionType = ActionTextType.CloseText;
    
	void Start () {
	
	}

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.GetComponent<CharacterMovement>() != null)
        {
            other.gameObject.GetComponent<CharacterMovement>().setHoverObj(this.gameObject);
        }
    }

    void OnCollisionExit(Collision other)
    {

        if (other.gameObject.GetComponent<CharacterMovement>() != null)
        {
            other.gameObject.GetComponent<CharacterMovement>().removeHoverObj(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterMovement>() != null)
        {
            other.GetComponent<CharacterMovement>().setHoverObj(this.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.GetComponent<CharacterMovement>() != null)
        {
            other.GetComponent<CharacterMovement>().removeHoverObj(this.gameObject);
        }
    }


    public void ClickAction()
    {
        switch (_actionType)
        {
            case ActionTextType.NextText:

                //this.gameObject.GetComponent<TileChanges>().updateCollision();

                break;
            default:


                break;
        }


    }
    public void HoverAction()
    {

    }
}