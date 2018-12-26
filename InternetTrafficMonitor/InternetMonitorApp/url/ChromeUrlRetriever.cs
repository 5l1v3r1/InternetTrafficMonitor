﻿using System.Windows.Automation;

namespace InternetMonitorApp.url
{
    public class ChromeUrlRetriever : UrlRetriever
    {
        protected override string GetUrl(AutomationElement element)
        {
            if (element == null) { return null; }

            var edit = element.FindFirst(TreeScope.Subtree,
                new AndCondition(
                    new PropertyCondition(AutomationElement.NameProperty, "address and search bar", PropertyConditionFlags.IgnoreCase),
                    new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit)));
            if (edit == null) { return null; }

            return ((ValuePattern)edit.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
        }
    }
}