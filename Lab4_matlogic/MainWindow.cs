﻿using System;
using System.Collections.Generic;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		this.button.Clicked += this.onCalcClick;
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected int getStartN(int n)
	{
		double D = 1 + 8 * ((double)n);
		return (int)((-1 + Math.Sqrt(D)) / 2.0);
	}

	protected List<int> generateTrinagleNum(int from, int to)
	{
		List<int> result = new List<int>();
		int realStart = getStartN(from);
		int realEnd = getStartN(to);
		for (int i = realStart; i <= realEnd; i++)
		{
			result.Add(i * (i + 1) / 2);
		}
		return result;
	}

	protected bool isMagic(int num)
	{
		String str = num.ToString();
		foreach (var c in str)
			if (str.Split(c).Length > 2) return false;
		return true;
	}

	protected List<int> getmagicNum(int from, int to)
	{
		List<int> result = new List<int>();
		for (int i = from; i < to; i++)
		{
			if (isMagic(i))
				result.Add(i);
		}
		return result;

	}

	protected List<int> merge(List<int> a, List<int> b)
	{
		List<int> result = new List<int>();
		List<int> source = a.Count < b.Count ? a : b;
		List<int> second = a.Count > b.Count ? a : b;
		foreach (int i in source)
			if (second.Contains(i))
				result.Add(i);
		return result;
	}

	protected void onCalcClick(object sender, EventArgs a)
	{
		int from = int.Parse(this.nField.Text);
		int to = int.Parse(this.mField.Text);
		var first = generateTrinagleNum(from, to);
		var second = getmagicNum(from, to);
		triangleResult.Text = first.stringify();
		magicResult.Text = second.stringify();
		result.Text = merge(first, second).stringify();
	}

}


public static class ListHelper
{
	public static string stringify(this List<int> s)
	{
		string result = "";
		foreach (int i in s)
			result += i.ToString() + " : ";
		return result;
	}
}