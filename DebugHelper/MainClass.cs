using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DebugHelper
{
    
    public class MainClass:MelonMod
    {
        public override void OnApplicationStart()
        {
            
        }
       
        public override void OnUpdate()
        {
            
        }
        
        public override void OnGUI()
        {
            Color oldcolor = GUI.color;
            GUI.color = Color.yellow;
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            GUILayout.Label(Camera.main.transform.position.ToString());
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 25f))
            {
                GameObject hitObject = hit.collider.gameObject;
                GUILayout.Label("Looking at(by name): " + hitObject.name);
                GUILayout.Label("Looking at(by tag): " + hitObject.tag);
            }
            GUI.color = oldcolor;
        }

    }
}
