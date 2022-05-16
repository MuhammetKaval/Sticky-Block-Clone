using UnityEngine;

public class CubeCounter : MonoBehaviour
{
    // cubeCounter'� sadece bir kere art���ndan emin olmak i�in gerekli trigger
    bool isTriggered = false;

    void Update()
    {
        // Toplanan k�plerin Move kompanenti aktif oldu�unda cubeCounter'� art�r�r.
        if (gameObject.GetComponent<Move>().isActiveAndEnabled && isTriggered == false)
        {
            GameManager.Instance.cubeCount++;
            isTriggered = true;
        }
    }


    // cubeCounter'� azalt�r ve e�er k�p kalmaz ise Oyunu sonland�r�r.
    private void OnDisable()
    {
        GameManager.Instance.cubeCount--;

        if (GameManager.Instance.cubeCount <= 0)
        {
            GameManager.Instance.GameOver();
        }
    }
}
