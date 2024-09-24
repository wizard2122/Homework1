using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Transform _shootPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //Instantiate(_cubePrefab);

            Bullet bullet = Instantiate(_bulletPrefab, _shootPoint.position, Quaternion.identity);
            bullet.Launch(Vector3.forward);
        }
    }
}
