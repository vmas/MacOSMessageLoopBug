using Avalonia.Controls;
using Avalonia.Threading;
using System;
using System.Threading;

namespace AvaloniaApplication1
{
	public partial class MainWindow : Window
	{
		private readonly Timer _timer;

		public MainWindow()
		{
			InitializeComponent();
			_timer = new Timer(UpdateMessage, null, 10, 10);
		}

		private void UpdateMessage(object _)
		{
			Dispatcher.UIThread.Post(UpdateInUIThread);
		}

		private void UpdateInUIThread()
		{
			this.Content = DateTime.UtcNow.Ticks.ToString();
		}
	}
}
