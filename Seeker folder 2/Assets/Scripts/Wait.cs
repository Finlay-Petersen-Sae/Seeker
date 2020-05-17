using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SubtitleSequence());
    }

    IEnumerator SubtitleSequence()
    {
           yield return new WaitForSeconds(5f);
           SceneManager.LoadScene(0);
    }
}
