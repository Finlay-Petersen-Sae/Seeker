using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SubtitleSO", order = 1)]
public class SubtitleSO : ScriptableObject
{
    public List<string> Subtitles = new List<string>();
    public List<AudioClip> AudioforSubs = new List<AudioClip>();
}
