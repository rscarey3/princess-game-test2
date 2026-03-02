using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance {get; private set;}

    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;
    public AudioClip skelebuildSFX;
    public AudioClip skeleshootSFX;
    public AudioClip skelehoverSFX;
    public AudioClip dragonbuildSFX;
    public AudioClip dragonshootSFX;
    public AudioClip dragonhoverSFX;
    public AudioClip plaguebuildSFX;
    public AudioClip plagueshootSFX;
    public AudioClip plaguehoverSFX;
    public AudioClip enemydeathSFX;
    public AudioClip enemyalertSFX;
    public AudioClip enemymoveSFX;
    public AudioClip bonePickupSFX;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        if (backgroundMusic != null && musicSource != null)
        {
            musicSource.clip = backgroundMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

   public void PlaySFX(AudioClip clip)
    {
        if(clip != null && sfxSource != null)
        {
            sfxSource.PlayOneShot(clip);
            //PlayOneShot plays an audio clip once
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        if(clip != null && musicSource != null)
        {
            musicSource.clip = clip;
            musicSource.loop = true;
            musicSource.Play();
        }
    }
}
