using UnityEngine;
using UnityEditor;
namespace Shonia
{
	public class HelicopterMenus
	{
		[MenuItem("Indie Pixel/Vehicles/Setup New Helicopter")]
		public static void BuildNewHelicopter()
		{
			GameObject curHeli = new GameObject("New_Helicopter", typeof(HeliController));

			GameObject curCOG = new GameObject("COG");
			curCOG.transform.SetParent(curHeli.transform);

			var con = curHeli.GetComponent<HeliController>();
			con.cog = curCOG.transform;

			var audioGRP = new GameObject("Audio_GRP");
			var graphicsGRP = new GameObject("Graphics_GRP");
			var colGRP = new GameObject("Collision_GRP");

            colGRP.transform.SetParent(curHeli.transform);
			graphicsGRP.transform.SetParent(curHeli.transform);
            audioGRP.transform.SetParent(curHeli.transform);
            Selection.activeGameObject = curHeli;
		}
	}
}
