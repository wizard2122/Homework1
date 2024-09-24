using System.Collections.Generic;
using UnityEngine;

public class BattleArena : MonoBehaviour
{
    private void Start()
    {
        List<Ork> orks = new List<Ork>(); 

        OrkPaladin orkPaladin = new OrkPaladin("���-�������", 35, 3, 10, 5);
        OrkMage orkMage = new OrkMage("���-���", 20, 5, 2);

        orks.Add(orkPaladin);
        orks.Add(orkMage);

        foreach (Ork ork in orks)
            ork.IssueCry();

        //ShowInfoAbout(orkPaladin);

        //ProcessBattle(orkMage, orkPaladin);

        //DetermineWinner(orkMage, orkPaladin);
    }

    private void DetermineWinner(OrkMage orkMage, OrkPaladin orkPaladin)
    {
        if (orkMage.Health > 0)
            Debug.Log($"������� {orkMage.Name}");
        else if (orkPaladin.Health > 0)
            Debug.Log($"������� {orkPaladin.Name}");
        else
            Debug.Log("�����");
    }

    private void ProcessBattle(OrkMage orkMage, OrkPaladin orkPaladin)
    {
        while(orkMage.Health > 0 && orkPaladin.Health > 0)
        {
            orkMage.CastSpell();
            orkPaladin.TakeDamage(orkMage.Damage);

            orkPaladin.Heal();
            orkMage.TakeDamage(orkPaladin.Damage);

            Debug.Log($"{orkPaladin.Name} - {orkPaladin.Health}");
            Debug.Log($"{orkMage.Name} - {orkMage.Health}");
        }
    }

    public void ShowInfoAbout(Ork ork)
    {
        Debug.Log($"���: {ork.Name}, ��: {ork.Health}");

        ork.IssueCry();

        ork.TakeDamage(10);
    }
}
