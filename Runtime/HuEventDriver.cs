using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HuEvent
{
	internal class HuEventDriver : MonoBehaviour
	{
		void Update()
		{
			HuEvent.InnerUpdate();
		}
	}
}