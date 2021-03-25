using UnityEngine;

public class BurnSteak : MonoBehaviour
{

    public Animator anim;
    private ParticleSystem smoke;
    private AudioSource audioSource;

    public static float totalBakeTime = 0;





    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        smoke = GetComponent<ParticleSystem>();
        audioSource = gameObject.GetComponent<AudioSource>();

        anim.SetInteger("burn", 0);
        this.anim.speed = 1;
        smoke.Stop();
        audioSource.Stop();

    }


    /// <summary>
    /// フライパンコライダーに接触している間アニメーターで焼き色を付ける
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "Pan")
        {

            this.anim.speed = 1;

            anim.SetInteger("burn", 1);

            totalBakeTime += Time.deltaTime;
        }
        else
        {
            this.anim.speed = 0;
            anim.SetInteger("burn", 0);

        }
    }


    /// <summary>
    /// フライパンコライダーに接触すると湯気と焼き音を再生
    /// </summary>
    /// <param name="collision"></param>
    void  OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Pan")
        {
            smoke.Play();
            audioSource.Play();
        }
        else
        {
            smoke.Stop();
            audioSource.Stop();

        }
        if (collision.gameObject.tag == "Abyss")

        {

            smoke.Play();
            audioSource.Play();

        }
        else
        {

            smoke.Stop();
            audioSource.Stop();

        }
    }


    /// <summary>
    /// Resultシーンに焼き時間を渡す
    /// </summary>
    /// <returns></returns>
    public static float gettotalBakeTime()
    {
        return totalBakeTime;
    }

}