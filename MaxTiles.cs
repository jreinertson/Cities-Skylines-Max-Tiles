using System;
using System.IO;
using System.Reflection;
using ICities;
using UnityEngine;

namespace MaxTilesMod
{
    public class Maxtiles : IUserMod {

        public string Name {
            get { return "Max Tiles"; }
        }

        public string Description {
            get { return "Can buy more than 9 tiles of a city"; }
        }
    }

    public class MaxTilesAreas : AreasExtensionBase{
		 
        public override bool OnCanUnlockArea(int x, int z, bool originalResult){
			return true; 
		 }
        public override void OnCreated(IAreas areas)
        {
            base.OnCreated(areas);
            areas.maxAreaCount = 25;
        }
         

     }
} 