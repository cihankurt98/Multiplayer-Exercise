using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  public void SetOn()
    {
        this.gameObject.SetActive(true);
    }

  public void SetOff()
    {
        this.gameObject.SetActive(false);
    }


}
