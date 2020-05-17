using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FinalAnimation : MonoBehaviour
{
    public SubtitleSO Subtitles;
    public Text SubtitleText;
    private float SubtitleWaitTime;
    public bool canSubtitle;
    public AudioSource Playersource;
    public GameObject Player, Black;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !canSubtitle)
        {
            StartCoroutine(SubtitleSequence());
            canSubtitle = true;
        }
    }

    IEnumerator SubtitleSequence()
    {
        for (int i = 0; i < Subtitles.Subtitles.Count; i++)
        {
            SubtitleText.text = Subtitles.Subtitles[i];
            Playersource.PlayOneShot(Subtitles.AudioforSubs[i]);
            if (Subtitles.Subtitles[i] == Subtitles.Subtitles[1])
            {
                Player.GetComponent<CharacterController>().enabled = false;
                yield return new WaitForSeconds(1);
                Player.GetComponentInChildren<Animation>().Play("Falling");
            }
            else if (Subtitles.Subtitles[i] == Subtitles.Subtitles[6])
            {
                Black.GetComponent<Animation>().Play("Fade");
            }
            yield return new WaitForSeconds(Subtitles.AudioforSubs[i].length + 0.2f);
        }
        SubtitleText.text = "";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Destroy(this.gameObject);
    }
}
