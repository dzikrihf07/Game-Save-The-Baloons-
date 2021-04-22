using UnityEngine;

public class btPindahKeUIMenu : MonoBehaviour
{
    public AudioSource buttonSound;

    public void SuaraTombol(){
        buttonSound.PlayOneShot (buttonSound.clip);
    }
    public void btPindah() {
        Application.LoadLevel("UIMenu");
    }
}