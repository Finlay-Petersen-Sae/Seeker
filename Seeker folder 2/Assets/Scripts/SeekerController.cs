using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekerController : MonoBehaviour
{
    public Camera PlayerCamera;
    public GameObject PostProcessing;
    public LayerMask SeekerLayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = this.GetComponent<Camera>();
        PostProcessing.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Show();
            PostProcessing.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Hide();
            PostProcessing.SetActive(false);
        }
    }

    private void Show()
    {
        PlayerCamera.cullingMask |= 1 << LayerMask.NameToLayer("SeekerLayer");
    }

    // Turn off the bit using an AND operation with the complement of the shifted int:
    private void Hide()
    {
        PlayerCamera.cullingMask &= ~(1 << LayerMask.NameToLayer("SeekerLayer"));
    }
}
