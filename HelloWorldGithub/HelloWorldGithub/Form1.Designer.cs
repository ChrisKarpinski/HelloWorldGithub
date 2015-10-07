namespace HelloWorldGithub
{
    partial class frmHelloWorldGithub
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(61, 68);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(62, 13);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello World";
            this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(155, 127);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(98, 23);
            this.btnShowMessage.TabIndex = 1;
            this.btnShowMessage.Text = "Show Message";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // frmHelloWorldGithub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShowMessage);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHelloWorldGithub";
            this.Text = "Hello World Github";
            this.Load += new System.EventHandler(this.frmHelloWorldGithub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnShowMessage;
    }
}

