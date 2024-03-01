using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace DebugHelper
{
    
    public static class Utilities
    {
        public static bool IsInGame => GameObject.FindGameObjectsWithTag("Player").Length <= 0;
        public static GameObject localplayer => GameObject.FindGameObjectWithTag("Player");
    }
}
