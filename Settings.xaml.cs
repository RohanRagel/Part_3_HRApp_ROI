using System;
using Microsoft.Maui.Controls;

namespace Part_3_HRApp_ROI
{
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();

            // Attach event handlers for the settings controls
            FontSizeSlider.ValueChanged += FontSizeSlider_ValueChanged;
            BrightnessSlider.ValueChanged += BrightnessSlider_ValueChanged;
            SoundEffectsSwitch.Toggled += SoundEffectsSwitch_Toggled;
        }

        private void FontSizeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Handle font size setting change
            double fontSize = e.NewValue;
            // Update the font size for your app's content
            // e.g., You might set the font size for a label like this:
            // myLabel.FontSize = fontSize;
        }

        private void BrightnessSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Handle brightness setting change
            double brightness = e.NewValue;
            // Update the brightness for your app's display
            // e.g., You might set the screen brightness like this:
            // DeviceDisplay.MainDisplayInfo.Brightness = brightness;
        }

        private void SoundEffectsSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            // Handle sound effects setting change
            bool soundEffectsEnabled = e.Value;
            // Enable or disable sound effects in your app
            // e.g., You might play or mute sound effects based on this setting.
        }
    }
}
