﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Reflection;

namespace _1660325_PhamBaLong
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		

		public MainWindow()
		{
			InitializeComponent();
			p1.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + @"\Images\av" + random() + ".jpg"));
			p2.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + @"\Images\dl" + random() + ".jpg"));
			p3.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + @"\Images\av" + random() + ".jpg"));
			p4.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + @"\Images\td" + random() + ".jpg"));

			System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

			dispatcherTimer.Tick += new EventHandler(changeImg);
			dispatcherTimer.Interval = new TimeSpan(0,0,5);
			dispatcherTimer.Start();

		}

		void changeImg(object sender, EventArgs e)
		{
			p1.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + @"\Images\av" + random() + ".jpg"));
			p2.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + @"\Images\dl" + random() + ".jpg"));
			p3.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + @"\Images\av" + random() + ".jpg"));
			p4.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + @"\Images\td" + random() + ".jpg"));
		}

		int random()
		{
			Random TenBienRanDom = new Random();
			int kq = TenBienRanDom.Next(0, 9);//Trả về giá trị kiểu int
			return kq;
		}
	}
}
