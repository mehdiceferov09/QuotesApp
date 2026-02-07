namespace Quotes_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewBtn = new Button();
            TextLbl = new Label();
            SuspendLayout();
            // 
            // NewBtn
            // 
            NewBtn.Location = new Point(31, 91);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(226, 64);
            NewBtn.TabIndex = 0;
            NewBtn.Text = "New quote";
            NewBtn.UseVisualStyleBackColor = true;
            NewBtn.Click += NewBtn_Click;
            // 
            // TextLbl
            // 
            TextLbl.AutoSize = true;
            TextLbl.Location = new Point(289, 101);
            TextLbl.Name = "TextLbl";
            TextLbl.Size = new Size(96, 45);
            TextLbl.TabIndex = 1;
            TextLbl.Text = "Blank";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 276);
            Controls.Add(TextLbl);
            Controls.Add(NewBtn);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewBtn;
        private Label TextLbl;
    }
}
