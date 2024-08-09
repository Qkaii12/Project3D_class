using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunAmmo : MonoBehaviour
{
    public int magSize;
    //public GrenadeLaucher gun;
    public Animator anim;
    public AudioSource[] reloadSounds;
    public UnityEvent loadedAmmoChanged;
    private int _loadedAmmo;
    public int LoadedAmmo
    {
        get => _loadedAmmo;
        set     
        {
            _loadedAmmo = value;
            loadedAmmoChanged.Invoke();
            if(_loadedAmmo <= 0)
            {
                //Reload();
            }
            else
            {
                //UnlockShooting();
            }
        }    
    }
}
