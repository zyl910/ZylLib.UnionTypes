using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ZylLib.UnionTypes;

namespace ZylLib.UnionTypes.SilverlightExample.sl40 {
	public partial class MainPage : UserControl {
		public MainPage() {
			InitializeComponent();
		}

		private void btnInfo_Click(object sender, RoutedEventArgs e) {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("ZylLib.UnionTypes.SilverlightExample");
			sb.AppendLine();
			UnionTypesExample.Output(sb);
			// show.
			txtOut.Text = sb.ToString();
		}
	}
}
