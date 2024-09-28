using UnityEngine;

public class Box : MonoBehaviour, IInteractable
{
    private float _currentScale;
    private bool _isInteracted;

    public void Interact()
    {
        _currentScale = transform.localScale.y;
        _isInteracted = true;
    }

    private void Update()
    {
        if (_isInteracted == false)
            return;

        if(_currentScale <= 0)
            Destroy(gameObject);

        _currentScale -= Time.deltaTime * 10;

        transform.localScale = new Vector3(_currentScale, _currentScale, _currentScale);
    }
}