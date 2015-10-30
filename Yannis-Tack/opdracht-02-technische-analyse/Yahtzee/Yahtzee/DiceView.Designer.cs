namespace Yahtzee
{
  partial class DiceView
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
      this.lblDice = new System.Windows.Forms.Label();
      this.btnThrow = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblDice
      // 
      this.lblDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDice.Location = new System.Drawing.Point(23, 22);
      this.lblDice.Name = "lblDice";
      this.lblDice.Size = new System.Drawing.Size(104, 58);
      this.lblDice.TabIndex = 0;
      this.lblDice.Text = "0";
      this.lblDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblDice.Click += new System.EventHandler(this.lblDice_Click);
      // 
      // btnThrow
      // 
      this.btnThrow.Location = new System.Drawing.Point(23, 99);
      this.btnThrow.Name = "btnThrow";
      this.btnThrow.Size = new System.Drawing.Size(104, 29);
      this.btnThrow.TabIndex = 1;
      this.btnThrow.Text = "Throw";
      this.btnThrow.UseVisualStyleBackColor = true;
      this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
      // 
      // DiceView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnThrow);
      this.Controls.Add(this.lblDice);
      this.Name = "DiceView";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblDice;
    private System.Windows.Forms.Button btnThrow;
  }
}
