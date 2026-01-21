using UnityEngine;

public class Damage : MonoBehaviour

{
    public int hp;
    public int BaseDamage;
    public float multiplyer;

    void Start()
    {
        int GottenDamage = Calculatehp(multiplyer);
        Debug.Log($"Аллозавр делает кусь и наносит {GottenDamage} урона герою, у которого было {hp} здоровья");
        hp = BaseDamage;
        Debug.Log($"теперь у героя {hp} здоровья");

    }
    private int Calculatehp( float multiplyer )
    {
        return (int)(BaseDamage * multiplyer);
    }
}

