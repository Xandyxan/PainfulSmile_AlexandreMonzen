using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Explosion : MonoBehaviour
{
    [SerializeField] string _pathCannonBallExplosion;

    private void OnEnable()
    {
        FMODUnity.RuntimeManager.PlayOneShot(_pathCannonBallExplosion);
    }

    private void DeactiveObject()
    {
        gameObject.SetActive(false);
    }
}
