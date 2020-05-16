using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitlePlayer : MonoBehaviour
{
    public SubtitleSO Subtitles;
    public Text SubtitleText;
    private float SubtitleWaitTime;
    public bool canSubtitle;
    public AudioSource Playersource;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !canSubtitle)
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
            yield return new WaitForSeconds(Subtitles.AudioforSubs[i].length + 0.2f);
        }
        SubtitleText.text = "";
        Destroy(this.gameObject);
    }
}
