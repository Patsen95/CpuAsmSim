﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace CpuSim
{
    public partial class CustomControl1 : Control
    {
        private TextFormatFlags textFlags = TextFormatFlags.Default;
        ComboBox comboBox1 = new ComboBox();
        Rectangle textBorder = new Rectangle();
        Rectangle textRectangle = new Rectangle();
        StringBuilder textMeasurements = new StringBuilder();

        public CustomControl1()
        {
            InitializeComponent();

            this.Location = new Point(10, 10);
            this.Size = new Size(300, 200);
            this.Font = SystemFonts.IconTitleFont;
            this.Text = "This is a long sentence that will exceed " +
                "the text box bounds";

            textBorder.Location = new Point(10, 10);
            textBorder.Size = new Size(200, 50);
            textRectangle.Location = new Point(textBorder.X + 2,
                textBorder.Y + 2);
            textRectangle.Size = new Size(textBorder.Size.Width - 4,
                textBorder.Height - 4);

            comboBox1.Location = new Point(10, 100);
            comboBox1.Size = new Size(150, 20);
            comboBox1.SelectedIndexChanged +=
                new EventHandler(comboBox1_SelectedIndexChanged);

            // Populate the combo box with the TextFormatFlags value names.
            foreach(string name in Enum.GetNames(typeof(TextFormatFlags)))
            {
                comboBox1.Items.Add(name);
            }

            comboBox1.SelectedIndex = 0;
            this.Controls.Add(comboBox1);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if(TextBoxRenderer.IsSupported)
            {
                TextBoxRenderer.DrawTextBox(e.Graphics, textBorder, this.Text,
                    this.Font, textRectangle, textFlags, TextBoxState.Normal);

                this.Parent.Text = "CustomTextBox Enabled";
            }
            else
            {
                this.Parent.Text = "CustomTextBox Disabled";
            }
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textFlags = (TextFormatFlags)Enum.Parse(
                typeof(TextFormatFlags),
                (string)comboBox1.Items[comboBox1.SelectedIndex]);
            Invalidate();
        }
    }
}
