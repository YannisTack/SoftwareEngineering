namespace RPSLS___Project
{
  partial class HandView
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
      this.btnRock = new System.Windows.Forms.Button();
      this.btnPaper = new System.Windows.Forms.Button();
      this.btnScissors = new System.Windows.Forms.Button();
      this.btnLizard = new System.Windows.Forms.Button();
      this.btnSpock = new System.Windows.Forms.Button();
      this.lblNaam = new System.Windows.Forms.Label();
      this.lblChoice = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnRock
      // 
      this.btnRock.BackColor = System.Drawing.Color.Aqua;
      this.btnRock.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnRock.Location = new System.Drawing.Point(30, 51);
      this.btnRock.Name = "btnRock";
      this.btnRock.Size = new System.Drawing.Size(75, 23);
      this.btnRock.TabIndex = 0;
      this.btnRock.Text = "Rock";
      this.btnRock.UseVisualStyleBackColor = false;
      this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
      // 
      // btnPaper
      // 
      this.btnPaper.BackColor = System.Drawing.Color.Aqua;
      this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnPaper.Location = new System.Drawing.Point(30, 80);
      this.btnPaper.Name = "btnPaper";
      this.btnPaper.Size = new System.Drawing.Size(75, 23);
      this.btnPaper.TabIndex = 1;
      this.btnPaper.Text = "Paper";
      this.btnPaper.UseVisualStyleBackColor = false;
      this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
      // 
      // btnScissors
      // 
      this.btnScissors.BackColor = System.Drawing.Color.Aqua;
      this.btnScissors.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnScissors.Location = new System.Drawing.Point(30, 109);
      this.btnScissors.Name = "btnScissors";
      this.btnScissors.Size = new System.Drawing.Size(75, 23);
      this.btnScissors.TabIndex = 3;
      this.btnScissors.Text = "Scissors";
      this.btnScissors.UseVisualStyleBackColor = false;
      this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
      // 
      // btnLizard
      // 
      this.btnLizard.BackColor = System.Drawing.Color.Aqua;
      this.btnLizard.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnLizard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnLizard.Location = new System.Drawing.Point(30, 138);
      this.btnLizard.Name = "btnLizard";
      this.btnLizard.Size = new System.Drawing.Size(75, 23);
      this.btnLizard.TabIndex = 2;
      this.btnLizard.Text = "Lizard";
      this.btnLizard.UseVisualStyleBackColor = false;
      this.btnLizard.Click += new System.EventHandler(this.btnLizard_Click);
      // 
      // btnSpock
      // 
      this.btnSpock.BackColor = System.Drawing.Color.Aqua;
      this.btnSpock.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSpock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSpock.Location = new System.Drawing.Point(30, 167);
      this.btnSpock.Name = "btnSpock";
      this.btnSpock.Size = new System.Drawing.Size(75, 23);
      this.btnSpock.TabIndex = 4;
      this.btnSpock.Text = "Spock";
      this.btnSpock.UseVisualStyleBackColor = false;
      this.btnSpock.Click += new System.EventHandler(this.btnSpock_Click);
      // 
      // lblNaam
      // 
      this.lblNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblNaam.Font = new System.Drawing.Font("Broadway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNaam.Location = new System.Drawing.Point(30, 12);
      this.lblNaam.Name = "lblNaam";
      this.lblNaam.Size = new System.Drawing.Size(75, 26);
      this.lblNaam.TabIndex = 5;
      this.lblNaam.Text = "Naam";
      this.lblNaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblChoice
      // 
      this.lblChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblChoice.Font = new System.Drawing.Font("Broadway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblChoice.Location = new System.Drawing.Point(30, 193);
      this.lblChoice.Name = "lblChoice";
      this.lblChoice.Size = new System.Drawing.Size(75, 26);
      this.lblChoice.TabIndex = 6;
      this.lblChoice.Text = "Choice";
      this.lblChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // HandView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblChoice);
      this.Controls.Add(this.lblNaam);
      this.Controls.Add(this.btnSpock);
      this.Controls.Add(this.btnScissors);
      this.Controls.Add(this.btnLizard);
      this.Controls.Add(this.btnPaper);
      this.Controls.Add(this.btnRock);
      this.Name = "HandView";
      this.Size = new System.Drawing.Size(140, 230);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnRock;
    private System.Windows.Forms.Button btnPaper;
    private System.Windows.Forms.Button btnScissors;
    private System.Windows.Forms.Button btnLizard;
    private System.Windows.Forms.Button btnSpock;
    private System.Windows.Forms.Label lblNaam;
    private System.Windows.Forms.Label lblChoice;
  }
}
