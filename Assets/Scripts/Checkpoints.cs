using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    [SerializeField] GameObject _gameObject = default;
    [SerializeField] private Light _ligth = default;
    [SerializeField] private Light _wallLigth = default;
    [SerializeField] private float _wallLigthIntensity = default;
    [SerializeField] private float _ligthIntensity = default;

    private void OnTriggerEnter(Collider other)
    {
        _ligth.GetComponent<Light>().intensity = _ligthIntensity;
        _wallLigth.GetComponent<Light>().intensity = _wallLigthIntensity;
        _gameObject.GetComponent<AudioSource>().enabled = true;
        _gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
