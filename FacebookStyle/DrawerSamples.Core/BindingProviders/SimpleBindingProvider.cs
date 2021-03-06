﻿using Intersoft.Crosslight;

namespace DrawerSamples
{
    public class SimpleBindingProvider : BindingProvider
    {
        #region Constructors

        public SimpleBindingProvider()
        {
            this.AddBinding("GreetingLabel", BindableProperties.TextProperty, "GreetingText");
            this.AddBinding("FooterLabel", BindableProperties.TextProperty, "FooterText");
            this.AddBinding("EditText", BindableProperties.TextProperty, new BindingDescription("NewText", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("Button1", BindableProperties.CommandProperty, "ShowToastCommand");
        }

        #endregion
    }
}