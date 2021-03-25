using UnityEngine;
using UnityEngine.UI;

public class ReadResult : MonoBehaviour {

    //private GameObject Score;
    public Text scoreText;

    /// <summary>
    /// 焼き時間を表示
    /// </summary>
    private void Awake()
    {
        float Result;
        Result = BurnSteak.gettotalBakeTime();
        scoreText.text = "焼き時間" + Result.ToString("f0") + "秒";
    }

   
}
