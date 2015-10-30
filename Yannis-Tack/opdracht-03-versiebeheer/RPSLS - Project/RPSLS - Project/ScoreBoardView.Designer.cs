namespace RPSLS___Project
{
  partial class ScoreBoardView
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
      this.lblSets = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblPoints
      // 
      this.lblPoints.AutoSize = true;
      this.lblPoints.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPoints.Location = new System.Drawing.Point(21, 26);
      this.lblPoints.Name = "lblPoints";
      this.lblPoints.Size = new System.Drawing.Size(84, 19);
      this.lblPoints.TabIndex = 0;
      this.lblPoints.Text = "Points: 5";
      // 
      // lblSets
      // 
      this.lblSets.AutoSize = true;
      this.lblSets.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSets.Location = new System.Drawing.Point(41, 64);
      this.lblSets.Name = "lblSets";
      this.lblSets.Size = new System.Drawing.Size(64, 19);
      this.lblSets.TabIndex = 1;
      this.lblSets.Text = "Sets: 2";
      // 
      // ScoreBoardView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblSets);
      this.Controls.Add(this.lblPoints);
      this.Name = "ScoreBoardView";
      this.Size = new System.Drawing.Size(140, 110);
      this.Load += new System.EventHandler(this.ScoreBoardView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblPoints;
    private System.Windows.Forms.Label lblSets;
  }
}
