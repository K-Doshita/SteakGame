using UnityEngine;

public class MeatMove : MonoBehaviour {

    [SerializeField]
    private GameObject fadeOutPanel;

    private MainFadeOutController fade;


    public void Start()
    {
        fade = fadeOutPanel.GetComponent<MainFadeOutController>();
    }

    /// <summary>
    /// 鉄板に肉が置かれたらフェードアウト開始
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
