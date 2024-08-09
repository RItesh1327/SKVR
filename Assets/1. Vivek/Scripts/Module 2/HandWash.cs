using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HandWash : MonoBehaviour
{
    public GameObject collisionObj;
    public ParticleSystem waterPS;
    public float startValue, endvalue;
    public UnityEvent OnDone;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject == collisionObj)
        {
            StartCoroutine(LerpFunction(startValue, endvalue, 3f));
        }
    }

    IEnumerator LerpFunction(float startValue, float endValue, float duration)
    {
        waterPS.gameObject.SetActive(true);
        var emission = waterPS.emission;

        float time = 0;

        while (time < duration)
        {
            emission.rateOverTime = Mathf.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        emission.rateOverTime = endValue;
        OnDone?.Invoke();
        gameObject.SetActive(false);
    }
}
