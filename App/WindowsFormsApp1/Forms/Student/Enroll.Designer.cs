namespace WindowsFormsApp1.Forms
{
    partial class Enroll
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enroll));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.SuspendLayout();
			// 
			// bunifuLabel6
			// 
			this.bunifuLabel6.AllowParentOverrides = false;
			this.bunifuLabel6.AutoEllipsis = false;
			this.bunifuLabel6.CursorType = null;
			this.bunifuLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.bunifuLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bunifuLabel6.Location = new System.Drawing.Point(263, 136);
			this.bunifuLabel6.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuLabel6.Name = "bunifuLabel6";
			this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bunifuLabel6.Size = new System.Drawing.Size(223, 37);
			this.bunifuLabel6.TabIndex = 25;
			this.bunifuLabel6.Text = "Student Name :";
			this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(498, 140);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(6);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(516, 33);
			this.comboBox3.TabIndex = 24;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// bunifuLabel1
			// 
			this.bunifuLabel1.AllowParentOverrides = false;
			this.bunifuLabel1.AutoEllipsis = false;
			this.bunifuLabel1.CursorType = null;
			this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bunifuLabel1.Location = new System.Drawing.Point(268, 250);
			this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuLabel1.Name = "bunifuLabel1";
			this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bunifuLabel1.Size = new System.Drawing.Size(184, 37);
			this.bunifuLabel1.TabIndex = 27;
			this.bunifuLabel1.Text = "Class Name:";
			this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(498, 254);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(516, 33);
			this.comboBox1.TabIndex = 26;
			// 
			// bunifuButton1
			// 
			this.bunifuButton1.AllowAnimations = true;
			this.bunifuButton1.AllowMouseEffects = true;
			this.bunifuButton1.AllowToggling = false;
			this.bunifuButton1.AnimationSpeed = 200;
			this.bunifuButton1.AutoGenerateColors = false;
			this.bunifuButton1.AutoRoundBorders = false;
			this.bunifuButton1.AutoSizeLeftIcon = true;
			this.bunifuButton1.AutoSizeRightIcon = true;
			this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
			this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.ButtonText = "Enroll";
			this.bunifuButton1.ButtonTextMarginLeft = 0;
			this.bunifuButton1.ColorContrastOnClick = 45;
			this.bunifuButton1.ColorContrastOnHover = 45;
			this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.bunifuButton1.CustomizableEdges = borderEdges1;
			this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
			this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
			this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
			this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuButton1.ForeColor = System.Drawing.SystemColors.Window;
			this.bunifuButton1.IconLeft = null;
			this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.bunifuButton1.IconMarginLeft = 11;
			this.bunifuButton1.IconPadding = 10;
			this.bunifuButton1.IconRight = null;
			this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.bunifuButton1.IconSize = 25;
			this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
			this.bunifuButton1.IdleBorderRadius = 0;
			this.bunifuButton1.IdleBorderThickness = 0;
			this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
			this.bunifuButton1.IdleIconLeftImage = null;
			this.bunifuButton1.IdleIconRightImage = null;
			this.bunifuButton1.IndicateFocus = false;
			this.bunifuButton1.Location = new System.Drawing.Point(498, 378);
			this.bunifuButton1.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuButton1.Name = "bunifuButton1";
			this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.bunifuButton1.OnDisabledState.BorderRadius = 1;
			this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.OnDisabledState.BorderThickness = 1;
			this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.bunifuButton1.OnDisabledState.IconLeftImage = null;
			this.bunifuButton1.OnDisabledState.IconRightImage = null;
			this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.bunifuButton1.onHoverState.BorderRadius = 1;
			this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.onHoverState.BorderThickness = 1;
			this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
			this.bunifuButton1.onHoverState.IconLeftImage = null;
			this.bunifuButton1.onHoverState.IconRightImage = null;
			this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Silver;
			this.bunifuButton1.OnIdleState.BorderRadius = 1;
			this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.OnIdleState.BorderThickness = 1;
			this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DimGray;
			this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.SystemColors.Window;
			this.bunifuButton1.OnIdleState.IconLeftImage = null;
			this.bunifuButton1.OnIdleState.IconRightImage = null;
			this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
			this.bunifuButton1.OnPressedState.BorderRadius = 1;
			this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.OnPressedState.BorderThickness = 1;
			this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
			this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.bunifuButton1.OnPressedState.IconLeftImage = null;
			this.bunifuButton1.OnPressedState.IconRightImage = null;
			this.bunifuButton1.Size = new System.Drawing.Size(196, 62);
			this.bunifuButton1.TabIndex = 29;
			this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.bunifuButton1.TextMarginLeft = 0;
			this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
			this.bunifuButton1.UseDefaultRadiusAndThickness = true;
			this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton2_Click);
			// 
			// Enroll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
			this.ClientSize = new System.Drawing.Size(1600, 865);
			this.Controls.Add(this.bunifuButton1);
			this.Controls.Add(this.bunifuLabel1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.bunifuLabel6);
			this.Controls.Add(this.comboBox3);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Enroll";
			this.Text = "Enroll";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private System.Windows.Forms.ComboBox comboBox3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
	}
}