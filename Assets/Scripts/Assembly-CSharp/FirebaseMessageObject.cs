using Firebase;
using Firebase.Messaging;
using HiGame;

public class FirebaseMessageObject : Singleton<FirebaseMessageObject>
{
	private FirebaseApp app;

	private bool isInitialized;

	public bool IsWaitingForCheckDependency { get; set; }

	protected override void OnInit()
	{
	}

	private void Start()
	{
	}

	public void SetupCallback()
	{
	}

	public void OnTokenReceived(object sender, TokenReceivedEventArgs token)
	{
	}

	public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
	{
	}
}
