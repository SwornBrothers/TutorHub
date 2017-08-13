namespace TutorHub
{
    partial class SignlePostTemplete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.postTitleLnk = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // postTitleLnk
            // 
            this.postTitleLnk.Location = new System.Drawing.Point(22, 34);
            this.postTitleLnk.Name = "postTitleLnk";
            this.postTitleLnk.Size = new System.Drawing.Size(667, 23);
            this.postTitleLnk.TabIndex = 0;
            this.postTitleLnk.Text = "post  Tile disi ekta ami onk josss";
            this.postTitleLnk.UseSelectable = true;
            // 
            // SignlePostTemplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.postTitleLnk);
            this.Name = "SignlePostTemplete";
            this.Size = new System.Drawing.Size(744, 278);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink postTitleLnk;
    }
}
