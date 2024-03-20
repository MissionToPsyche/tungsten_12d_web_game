using UnityEngine;

public class OpenWebsite : MonoBehaviour
{
    public string URL;

    public void Open()
    {
        Application.OpenURL(URL);
    }
}
