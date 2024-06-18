using TMPro;
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
   public float timer, refresh, avgFramerate;
   public string display = "{0}";
   public TMP_Text m_Text;

   private void Update()
   {
      float timelapse = Time.smoothDeltaTime;
      timer = timer <= 0 ? refresh : timer -= timelapse;

      if (timer <= 0) avgFramerate = (int)(1f / timelapse);
      m_Text.text = string.Format(display,avgFramerate.ToString());
   }
}
