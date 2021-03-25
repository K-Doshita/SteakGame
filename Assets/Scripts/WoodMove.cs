using UnityEngine;

public class WoodMove : MonoBehaviour {

    private StartFadeOutController fade;

    public void Start()
    {
        fade = GameObject.Find("FadeOutImage").GetComponent<StartFadeOutController>();
    }

    /// <summary>
    /// まな板に肉が置かれたらフェードアウト開始
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Meat")
        {
            fade.isFadeOUt = true;
        }
    }

  
}
