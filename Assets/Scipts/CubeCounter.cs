using UnityEngine;

public class CubeCounter : MonoBehaviour
{
    // cubeCounter'ý sadece bir kere artýðýndan emin olmak için gerekli trigger
    bool isTriggered = false;

    void Update()
    {
        // Toplanan küplerin Move kompanenti aktif olduðunda cubeCounter'ý artýrýr.
        if (gameObject.GetComponent<Move>().isActiveAndEnabled && isTriggered == false)
        {
            GameManager.Instance.cubeCount++;
            isTriggered = true;
        }
    }


    // cubeCounter'ý azaltýr ve eðer küp kalmaz ise Oyunu sonlandýrýr.
    private void OnDisable()
    {
        GameManager.Instance.cubeCount--;

        if (GameManager.Instance.cubeCount <= 0)
        {
            GameManager.Instance.GameOver();
        }
    }
}
