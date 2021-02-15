namespace kMeans
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_drawLines = new System.Windows.Forms.Button();
            this.btn_Centroizi = new System.Windows.Forms.Button();
            this.label_nrCentr = new System.Windows.Forms.Label();
            this.btn_GenPct = new System.Windows.Forms.Button();
            this.btn_Grupare = new System.Windows.Forms.Button();
            this.btn_Centrare = new System.Windows.Forms.Button();
            this.btn_blank = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostMicLabel = new System.Windows.Forms.Label();
            this.OprireLabel = new System.Windows.Forms.Label();
            this.label_coord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 738);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btn_drawLines
            // 
            this.btn_drawLines.Location = new System.Drawing.Point(889, 36);
            this.btn_drawLines.Margin = new System.Windows.Forms.Padding(4);
            this.btn_drawLines.Name = "btn_drawLines";
            this.btn_drawLines.Size = new System.Drawing.Size(100, 28);
            this.btn_drawLines.TabIndex = 1;
            this.btn_drawLines.Text = "Draw Lines";
            this.btn_drawLines.UseVisualStyleBackColor = true;
            this.btn_drawLines.Click += new System.EventHandler(this.btn_drawLines_Click);
            // 
            // btn_Centroizi
            // 
            this.btn_Centroizi.Location = new System.Drawing.Point(889, 82);
            this.btn_Centroizi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Centroizi.Name = "btn_Centroizi";
            this.btn_Centroizi.Size = new System.Drawing.Size(100, 44);
            this.btn_Centroizi.TabIndex = 2;
            this.btn_Centroizi.Text = "Generare Centroizi";
            this.btn_Centroizi.UseVisualStyleBackColor = true;
            this.btn_Centroizi.Click += new System.EventHandler(this.btn_Centroizi_Click);
            // 
            // label_nrCentr
            // 
            this.label_nrCentr.AutoSize = true;
            this.label_nrCentr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nrCentr.Location = new System.Drawing.Point(836, 697);
            this.label_nrCentr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nrCentr.Name = "label_nrCentr";
            this.label_nrCentr.Size = new System.Drawing.Size(138, 20);
            this.label_nrCentr.TabIndex = 3;
            this.label_nrCentr.Text = "Numar centroizi: ";
            // 
            // btn_GenPct
            // 
            this.btn_GenPct.Location = new System.Drawing.Point(889, 148);
            this.btn_GenPct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GenPct.Name = "btn_GenPct";
            this.btn_GenPct.Size = new System.Drawing.Size(100, 43);
            this.btn_GenPct.TabIndex = 4;
            this.btn_GenPct.Text = "Generare Puncte";
            this.btn_GenPct.UseVisualStyleBackColor = true;
            this.btn_GenPct.Click += new System.EventHandler(this.btn_GenPct_Click);
            // 
            // btn_Grupare
            // 
            this.btn_Grupare.Location = new System.Drawing.Point(889, 210);
            this.btn_Grupare.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Grupare.Name = "btn_Grupare";
            this.btn_Grupare.Size = new System.Drawing.Size(100, 28);
            this.btn_Grupare.TabIndex = 5;
            this.btn_Grupare.Text = "Grupare";
            this.btn_Grupare.UseVisualStyleBackColor = true;
            this.btn_Grupare.Click += new System.EventHandler(this.btn_Grupare_Click);
            // 
            // btn_Centrare
            // 
            this.btn_Centrare.Location = new System.Drawing.Point(889, 260);
            this.btn_Centrare.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Centrare.Name = "btn_Centrare";
            this.btn_Centrare.Size = new System.Drawing.Size(100, 28);
            this.btn_Centrare.TabIndex = 6;
            this.btn_Centrare.Text = "Centrare";
            this.btn_Centrare.UseVisualStyleBackColor = true;
            this.btn_Centrare.Click += new System.EventHandler(this.btn_Centrare_Click);
            // 
            // btn_blank
            // 
            this.btn_blank.Location = new System.Drawing.Point(889, 308);
            this.btn_blank.Margin = new System.Windows.Forms.Padding(4);
            this.btn_blank.Name = "btn_blank";
            this.btn_blank.Size = new System.Drawing.Size(100, 28);
            this.btn_blank.TabIndex = 7;
            this.btn_blank.Text = "Blank";
            this.btn_blank.UseVisualStyleBackColor = true;
            this.btn_blank.Click += new System.EventHandler(this.btn_blank_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(836, 356);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(49, 20);
            this.CostLabel.TabIndex = 8;
            this.CostLabel.Text = "Cost:";
            // 
            // CostMicLabel
            // 
            this.CostMicLabel.AutoSize = true;
            this.CostMicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostMicLabel.Location = new System.Drawing.Point(836, 389);
            this.CostMicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostMicLabel.Name = "CostMicLabel";
            this.CostMicLabel.Size = new System.Drawing.Size(123, 18);
            this.CostMicLabel.TabIndex = 9;
            this.CostMicLabel.Text = "Cel mai mic cost:";
            // 
            // OprireLabel
            // 
            this.OprireLabel.AutoSize = true;
            this.OprireLabel.Location = new System.Drawing.Point(843, 428);
            this.OprireLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OprireLabel.Name = "OprireLabel";
            this.OprireLabel.Size = new System.Drawing.Size(48, 17);
            this.OprireLabel.TabIndex = 10;
            this.OprireLabel.Text = "Oprire";
            // 
            // label_coord
            // 
            this.label_coord.AutoSize = true;
            this.label_coord.Location = new System.Drawing.Point(886, 483);
            this.label_coord.Name = "label_coord";
            this.label_coord.Size = new System.Drawing.Size(46, 17);
            this.label_coord.TabIndex = 11;
            this.label_coord.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 802);
            this.Controls.Add(this.label_coord);
            this.Controls.Add(this.OprireLabel);
            this.Controls.Add(this.CostMicLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.btn_blank);
            this.Controls.Add(this.btn_Centrare);
            this.Controls.Add(this.btn_Grupare);
            this.Controls.Add(this.btn_GenPct);
            this.Controls.Add(this.label_nrCentr);
            this.Controls.Add(this.btn_Centroizi);
            this.Controls.Add(this.btn_drawLines);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_drawLines;
        private System.Windows.Forms.Button btn_Centroizi;
        private System.Windows.Forms.Label label_nrCentr;
        private System.Windows.Forms.Button btn_GenPct;
        private System.Windows.Forms.Button btn_Grupare;
        private System.Windows.Forms.Button btn_Centrare;
        private System.Windows.Forms.Button btn_blank;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CostMicLabel;
        private System.Windows.Forms.Label OprireLabel;
        private System.Windows.Forms.Label label_coord;
    }
}

