using UnityEngine;
using System.Collections;

namespace Runner
{
	public class CameraFollow : MonoBehaviour
	{
		[SerializeField] private Transform _player;

		void Update()
		{
			transform.position = new Vector3(_player.position.x + 6, 0, transform.position.z);
		}
	}
}
