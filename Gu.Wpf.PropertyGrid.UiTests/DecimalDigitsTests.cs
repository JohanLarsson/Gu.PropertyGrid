﻿namespace Gu.Wpf.PropertyGrid.UiTests
{
    using NUnit.Framework;
    using TestStack.White;
    using TestStack.White.UIItems;
    using TestStack.White.UIItems.WindowItems;

    public class DecimalDigitsTests
    {
        private Application application;
        private Window window;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var title = "DecimalDigitsWindow";
            this.application = Application.AttachOrLaunch(Info.CreateStartInfo(title));
            this.window = this.application.GetWindow(title);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.application?.Dispose();
        }

        [Test]
        public void Inherits()
        {
            var groupBox = this.window.GetByText<GroupBox>("attached prop");
            var doubleBox = groupBox.FindSetting("double").Get<TextBox>();
            Assert.AreEqual("0.00", doubleBox.Text);

            var lengthBox = groupBox.FindSetting("double").Get<TextBox>();
            Assert.AreEqual("12.35", lengthBox.Text);
        }
    }
}