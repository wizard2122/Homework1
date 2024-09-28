using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleSpawner : MonoBehaviour
{
    [SerializeField] private Humanoid _humanoidPrefab;

    private void Awake()
    {
        Humanoid ork = Instantiate(_humanoidPrefab);
        ork.Initialize(new MeleeAttack(), new ArmorHealth(100, 20));

        Humanoid elf = Instantiate(_humanoidPrefab);
        elf.Initialize(new RangeAttack(), new AgilityHealth(8, 60));

        Humanoid robot = Instantiate(_humanoidPrefab);
        robot.Initialize(new RangeAttack(), new ArmorHealth(300, 100));
    }
}
