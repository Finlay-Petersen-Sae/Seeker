using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoPlay : MonoBehaviour
{
    public SubtitleSO Subtitles;
    public AudioSource Playersource;

    public void Start()
    {
        StartCoroutine(SubtitleSequence());
    }

    IEnumerator SubtitleSequence()
    {
        for (int i = 0; i < Subtitles.AudioforSubs.Count; i++)
        {
            Playersource.PlayOneShot(Subtitles.AudioforSubs[i]);
            yield return new WaitForSeconds(Subtitles.AudioforSubs[i].length + 1f);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Destroy(this.gameObject);
    }
}
