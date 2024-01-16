using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HuEvent
{
	public static class HuEvent
	{
		private static bool _isInited = false;
		private static GameObject _goEventDriver = null;
		private static readonly Dictionary<int, LinkedList<IEventMessage>> _eventLists = new Dictionary<int, LinkedList<IEventMessage>>(500);

		public static void Initalize()
		{
			if (_isInited)
				throw new Exception($"{nameof(HuEvent)} is initialized !");
			if(_isInited == false)
			{
				_goEventDriver = new GameObject($"{nameof(HuEvent)}");
				_goEventDriver.AddComponent<HuEventDriver>();
				UnityEngine.Object.DontDestroyOnLoad(_goEventDriver);
				Debug.Log($"{nameof(HuEvent)} initalize !");
			}
		}

		internal static void InnerUpdate()
		{

		}
	}
}


