namespace FindingPi
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.NumericUpDown();
            this.Output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Submitbutton_clicked);
            // 
            // InputPanel
            // 
            this.InputPanel.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.InputPanel.InterceptArrowKeys = false;
            this.InputPanel.Location = new System.Drawing.Point(195, 38);
            this.InputPanel.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.InputPanel.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(120, 22);
            this.InputPanel.TabIndex = 2;
            this.InputPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InputPanel.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(192, 110);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(44, 16);
            this.Output.TabIndex = 3;
            this.Output.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.InputPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown InputPanel;
        private System.Windows.Forms.Label Output;
    }
}