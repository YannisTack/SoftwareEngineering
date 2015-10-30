namespace Yahtzee
{
  partial class YahtzeeView
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
      this.btnThrowAll = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnThrowAll
      // 
      this.btnThrowAll.Location = new System.Drawing.Point(34, 160);
      this.btnThrowAll.Name = "btnThrowAll";
      this.btnThrowAll.Size = new System.Drawing.Size(75, 23);
      this.btnThrowAll.TabIndex = 0;
      this.btnThrowAll.Text = "Throw All";
      this.btnThrowAll.UseVisualStyleBackColor = true;
      this.btnThrowAll.Click += new System.EventHandler(this.btnThrowAll_Click);
      // 
      // YahtzeeView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.btnThrowAll);
      this.Name = "YahtzeeView";
      this.Size = new System.Drawing.Size(150, 200);
      this.Load += new System.EventHandler(this.YahtzeeView_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnThrowAll;
  }
}
