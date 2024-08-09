using System.Collections;
using UnityEngine;

namespace BzKovSoft.ObjectSlicer.Samples
{
	/// <summary>
	/// This script will invoke slice method of IBzSliceableNoRepeat interface if knife slices this GameObject.
	/// The script must be attached to a GameObject that have rigidbody on it and
	/// IBzSliceable implementation in one of its parent.
	/// </summary>
	[DisallowMultipleComponent]
	public class KnifeSliceableAsync : MonoBehaviour
	{
		IBzSliceableNoRepeat _sliceableAsync;
		GameObject WrongKnifePanel;


		void Start()
		{
			_sliceableAsync = GetComponentInParent<IBzSliceableNoRepeat>();

			if (GetComponent<ObjectSlicerSample>() != null)
			{
				if (GetComponent<ObjectSlicerSample>().WrongKnifePanel != null)
				{
					WrongKnifePanel = GetComponent<ObjectSlicerSample>().WrongKnifePanel;
				}
			}
		}

		void OnTriggerEnter(Collider other)
		{
			var knife = other.gameObject.GetComponent<BzKnife>();
			if (knife == null)
				return;

			if (GetComponent<ObjectSlicerSample>() != null)
			{
				if (GetComponent<ObjectSlicerSample>().isKnifeSpecified)
				{
					if (knife == GetComponent<ObjectSlicerSample>().knife)
					{
						StartCoroutine(Slice(knife));
						WrongKnifePanel.SetActive(false);
					}
					else
					{
						if (WrongKnifePanel.activeInHierarchy == false)
						{
							WrongKnifePanel.SetActive(true);
							WrongKnifePanel.transform.parent = knife.transform.parent;
							WrongKnifePanel.transform.localPosition = new Vector3(0.05f, 0, -0.11f);
							WrongKnifePanel.transform.localRotation = Quaternion.Euler(90, 90, 0);
							Debug.Log("Wrong knife selected for cutting");
						}
					}
				}else
				{
                    StartCoroutine(Slice(knife));
                }
			}
			else
			{
				StartCoroutine(Slice(knife));
			}
		}

		private IEnumerator Slice(BzKnife knife)
		{
			// The call from OnTriggerEnter, so some object positions are wrong.
			// We have to wait for next frame to work with correct values
			yield return null;

			Vector3 point = GetCollisionPoint(knife);
			Vector3 normal = Vector3.Cross(knife.MoveDirection, knife.BladeDirection);
			Plane plane = new Plane(normal, point);

			if (_sliceableAsync != null)
			{
				_sliceableAsync.Slice(plane, knife.SliceID, null);

				/*if(GetComponentInParent<AudioSource>() != null)
				{
					if(GetComponentInParent<AudioSource>().isPlaying)
					{
                        GetComponentInParent<AudioSource>().Stop();
                    }
					GetComponentInParent<AudioSource>().Play();
				}*/
			}
		}

		private Vector3 GetCollisionPoint(BzKnife knife)
		{
			Vector3 distToObject = transform.position - knife.Origin;
			Vector3 proj = Vector3.Project(distToObject, knife.BladeDirection);

			Vector3 collisionPoint = knife.Origin + proj;
			return collisionPoint;
		}
	}
}