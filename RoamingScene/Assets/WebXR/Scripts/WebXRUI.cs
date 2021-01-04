using System.Runtime.InteropServices;
using UnityEngine;

namespace WebXR
{
	public class WebXRUI
	{

		[DllImport("__Internal")]
		public static extern void displayXRElementId(string id);
		[DllImport("__Internal")]
		public static extern void ClickButtonXRElementEvent(string name);


	}
}