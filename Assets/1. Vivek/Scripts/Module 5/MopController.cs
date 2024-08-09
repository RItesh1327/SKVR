using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MopController : MonoBehaviour
{
    public GameObject water;
    IEnumerator DecreaseScale;
    [HideInInspector] public bool isFunctionAlreadyCalled = false;
    public UnityEvent OnMopDone;

    // Start is called before the first frame update
    void Start()
    {
        DecreaseScale = RotationLerper(new Vector3(0.2f, 1f, 0.2f), 3);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == water)
        {
            if (!isFunctionAlreadyCalled)
            {
                OnKnobRotateStart();
            }
            else
            {
                OnKnobRotateStop();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == water)
        {
            OnKnobRotateStop();
        }
    }

    public void OnKnobRotateStart()
    {
        if (GetComponent<MopController>().enabled)
        {
            isFunctionAlreadyCalled = true;
            if (DecreaseScale != null)
                StartCoroutine(DecreaseScale);
        }
    }

    public void OnKnobRotateStop()
    {
        if (GetComponent<MopController>().enabled)
        {
            isFunctionAlreadyCalled = false;
            if (DecreaseScale != null)
                StopCoroutine(DecreaseScale);
        }
    }

    IEnumerator RotationLerper(Vector3 endValue, float duration)
    {
        float time = 0;
        Vector3 startValue = water.transform.localScale;

        while (time < duration)
        {
            water.transform.localScale = Vector3.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        water.transform.localScale = endValue;
        water.SetActive(false);
        OnMopDone?.Invoke();
    }
}
