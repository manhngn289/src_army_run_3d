using System.Collections.Generic;
using Google.Play.Common.LoadingScreen;
using UnityEngine;
using UnityEngine.UI;

namespace Google.Play.AppUpdate.Samples.AppUpdateDemo.Scripts
{
	public class UpdateDownloadDisplay : MonoBehaviour
	{
		public Text statusText;

		public Image colorTint;

		public LoadingBar loadingBar;

		public ScrollingFillAnimator scrollingFill;

		public Color errorColor;

		public Color successColor;

		public Color neutralColor;

		private readonly IDictionary<AppUpdateStatus, Color> _colorsByStatus;

		private const float ActiveScrollSpeed = 2.5f;

		public void BindColor(Color color, AppUpdateStatus status)
		{
		}

		public void SetProgressBarDisplayActive(bool progressBarActive)
		{
		}

		public void SetScrolling(bool scrolling)
		{
		}

		public void SetInitialStatus(bool isDownloaded)
		{
		}

		public void SetStatus(AppUpdateStatus status)
		{
		}

		public void SetStatusText(string text)
		{
		}

		public void SetProgress(float progress)
		{
		}

		public string FormatSize(ulong numBytes)
		{
			return null;
		}
	}
}
