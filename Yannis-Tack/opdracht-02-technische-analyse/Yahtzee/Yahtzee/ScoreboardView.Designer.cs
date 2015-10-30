namespace Yahtzee
{
  partial class ScoreboardView
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
      this.lblPoints = new System.Windows.Forms.Label();
      this.lblThrows = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblPoints
      // 
      this.lblPoints.AutoSize = true;
      this.lblPoints.Location = new System.Drawing.Point(28, 16);
      this.lblPoints.Name = "lblPoints";
      this.lblPoints.Size = new System.Drawing.Size(48, 13);
      this.lblPoints.TabIndex = 0;
      this.lblPoints.Text = "Points: 5";
      // 
      // lblThrows
      // 
      this.lblThrows.AutoSize = true;
      this.lblThrows.Location = new System.Drawing.Point(27, 35);
      this.lblThrows.Name = "lblThrows";
      this.lblThrows.Size = new System.Drawing.Size(65, 13);
      this.lblThrows.TabIndex = 1;
      this.lblThrows.Text = "Throws: 0/5";
      // 
      // ScoreboardView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblThrows);
      this.Controls.Add(this.lblPoints);
      this.Name = "ScoreboardView";
      this.Size = new System.Drawing.Size(138, 62);
      this.Load += new System.EventHandler(this.ScoreboardView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblPoints;
    private System.Windows.Forms.Label lblThrows;
  }
}
