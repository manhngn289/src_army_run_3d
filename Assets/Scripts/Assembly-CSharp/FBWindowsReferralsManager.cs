using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class FBWindowsReferralsManager : MonoBehaviour
{
	public FBWindowsLogsManager Logger;

	public InputField Payload;

	public InputField ReferralLinks;

	private string _referral_example_payload;

	private void OnEnable()
	{
	}

	public void CreateReferral()
	{
	}

	private void CallbackReferralsCreate(IReferralsCreateResult result)
	{
	}

	public void GetDataReferral()
	{
	}

	private void CallbackReferralsGetData(IReferralsGetDataResult result)
	{
	}
}
