using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine"))
        {

            gameObject.GetComponent<Move>().enabled = false;
            gameObject.GetComponent<SwerveSystem>().enabled = false;
            GameManager.Instance.isReachFinishLine = true;     // ChangeShape'ý aktif hale getirmek için

            //GameManager.Instance.isGameActive = false;       // Hareketi kesmek için
            //GameManager.Instance.isReachFinishLine = true;     // ChangeShape'ý aktif hale getirmek için
            //other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
