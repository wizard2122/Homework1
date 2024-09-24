using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private Vector3 _defaultPosition;
    private float _time;

    [SerializeField] private float _amplitude;
    [SerializeField] private float _frequency;
    [SerializeField] private float _phase;

    [SerializeField] private float _fadeMultiplier;

    private void Awake()
    {
        _defaultPosition = transform.position;
    }

    private void Update()
    {
        _time += Time.deltaTime;

        transform.position = _defaultPosition + Vector3.up * _amplitude * Mathf.Sin(_time * _frequency + _phase) * Mathf.Exp(-_time * _fadeMultiplier);
    }
}
