﻿using ObjectScouter.Model;
using System.Reflection;

namespace ObjectScouter.UserInteraction
{
	internal interface IUserInteraction
    {
        void DisplayText(string text);
		string GetValidString(string prompt = "");
		void ListProperties(IEnumerable<string> properties);
		void ListItems(IEnumerable<Item> items);
		void WaitForAnyInput();
	}
}
