using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject outroCamera;

    public GameObject Explosion1;
    public GameObject Explosion2;
    public GameObject Explosion3;
    public GameObject Explosion4;

    public AudioSource ExplosionSound1;
    public AudioSource ExplosionSound2;
    public AudioSource ExplosionSound3;
    public AudioSource ExplosionSound4;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(fadeToNextScene());
        }
    }

    IEnumerator fadeToNextScene()
    {
        mainCamera.SetActive(false);
        outroCamera.SetActive(true);
        yield return new WaitForSeconds(1);
        outroCamera.GetComponent<CameraFadeOut>().fadeOut = true;
        ExplosionSound1.Play();
        Explosion1.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(0.5f);
        ExplosionSound2.Play();
        Explosion2.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(0.2f);
        ExplosionSound3.Play();
        Explosion3.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(0.3f);
        ExplosionSound4.Play();
        Explosion4.GetComponent<ParticleSystem>().Play();

        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("2.Oceanfloor");
    }
}
