using UnityEngine;

public class DishMove : MonoBehaviour
{
    private ResultFadeOutController fade;

    public void Start()
    {
        fade = GameObject.Find("FadeOutImage").GetComponent<ResultFadeOutController>();
    }

    /// <summary>
    /// 皿にフォークが置かれたらフェードアウト開始
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fork")
        {
            fade.isFadeOUt = true;
        }
    }

}
