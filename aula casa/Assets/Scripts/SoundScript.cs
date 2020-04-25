using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundScript : MonoBehaviour
{
	[SerializeField] private AudioSource effectsSource;
    //[SerializeField] private PointsScript pointsScript;
    public AudioClip sfxCollect;
    public AudioClip sfxSuccess;

	private void Awake()
	{
		effectsSource = GetComponent<AudioSource>();
        effectsSource.clip = sfxCollect;
	}

    private void OnEnable()
    {
        //registrando a função "PlaySoundEffect" no evento "OnItemCollected"
        PointsScript.OnItemCollected += PlaySoundEffect;
        PointsScript.OnWinCondition += PlaySuccessSound;
    }

    private void OnDisable()
    {
        //Removendo a função "PlaySoundEffect" no evento "OnItemCollected"
        PointsScript.OnItemCollected -= PlaySoundEffect;
        PointsScript.OnWinCondition -= PlaySuccessSound;
    }

    public void PlaySoundEffect()
	{
		if(effectsSource.clip != null)
			effectsSource.Play();
	}

    public void PlaySuccessSound()
    {
        effectsSource.clip = null;
        effectsSource.PlayOneShot(sfxSuccess);
    }
}
