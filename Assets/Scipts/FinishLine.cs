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
            GameManager.Instance.isReachFinishLine = true;     // ChangeShape'� aktif hale getirmek i�in

            //GameManager.Instance.isGameActive = false;       // Hareketi kesmek i�in
            //GameManager.Instance.isReachFinishLine = true;     // ChangeShape'� aktif hale getirmek i�in
            //other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
