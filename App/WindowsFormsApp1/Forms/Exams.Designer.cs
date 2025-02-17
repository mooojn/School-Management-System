namespace WindowsFormsApp1.Forms
{
    partial class EvaluateStudent
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluateStudent));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
			this.save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.name = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bunifuDropdown2 = new Bunifu.UI.WinForms.BunifuDropdown();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
			this.bunifuDropdown3 = new Bunifu.UI.WinForms.BunifuDropdown();
			this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
			this.StudentsData = new Bunifu.UI.WinForms.BunifuDataGridView();
			this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
			this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rubricLevelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel3.SuspendLayout();
			this.bunifuPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StudentsData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
			this.panel3.Controls.Add(this.bunifuPanel1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 761);
			this.panel3.Margin = new System.Windows.Forms.Padding(6);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1600, 104);
			this.panel3.TabIndex = 7;
			// 
			// bunifuPanel1
			// 
			this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
			this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
			this.bunifuPanel1.BorderRadius = 3;
			this.bunifuPanel1.BorderThickness = 1;
			this.bunifuPanel1.Controls.Add(this.save);
			this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.bunifuPanel1.Location = new System.Drawing.Point(900, 0);
			this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuPanel1.Name = "bunifuPanel1";
			this.bunifuPanel1.ShowBorders = true;
			this.bunifuPanel1.Size = new System.Drawing.Size(700, 104);
			this.bunifuPanel1.TabIndex = 9;
			// 
			// save
			// 
			this.save.AllowAnimations = true;
			this.save.AllowMouseEffects = true;
			this.save.AllowToggling = false;
			this.save.AnimationSpeed = 200;
			this.save.AutoGenerateColors = false;
			this.save.AutoRoundBorders = false;
			this.save.AutoSizeLeftIcon = true;
			this.save.AutoSizeRightIcon = true;
			this.save.BackColor = System.Drawing.Color.Transparent;
			this.save.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
			this.save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.ButtonText = "Evaluate";
			this.save.ButtonTextMarginLeft = 0;
			this.save.ColorContrastOnClick = 45;
			this.save.ColorContrastOnHover = 45;
			this.save.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.save.CustomizableEdges = borderEdges1;
			this.save.DialogResult = System.Windows.Forms.DialogResult.None;
			this.save.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.save.DisabledFillColor = System.Drawing.Color.Empty;
			this.save.DisabledForecolor = System.Drawing.Color.Empty;
			this.save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
			this.save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.save.ForeColor = System.Drawing.Color.White;
			this.save.IconLeft = null;
			this.save.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.save.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.save.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.save.IconMarginLeft = 11;
			this.save.IconPadding = 10;
			this.save.IconRight = null;
			this.save.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.save.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.save.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.save.IconSize = 25;
			this.save.IdleBorderColor = System.Drawing.Color.Empty;
			this.save.IdleBorderRadius = 0;
			this.save.IdleBorderThickness = 0;
			this.save.IdleFillColor = System.Drawing.Color.Empty;
			this.save.IdleIconLeftImage = null;
			this.save.IdleIconRightImage = null;
			this.save.IndicateFocus = false;
			this.save.Location = new System.Drawing.Point(480, 19);
			this.save.Margin = new System.Windows.Forms.Padding(6);
			this.save.Name = "save";
			this.save.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.save.OnDisabledState.BorderRadius = 1;
			this.save.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.OnDisabledState.BorderThickness = 1;
			this.save.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.save.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.save.OnDisabledState.IconLeftImage = null;
			this.save.OnDisabledState.IconRightImage = null;
			this.save.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.save.onHoverState.BorderRadius = 1;
			this.save.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.onHoverState.BorderThickness = 1;
			this.save.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.save.onHoverState.ForeColor = System.Drawing.Color.White;
			this.save.onHoverState.IconLeftImage = null;
			this.save.onHoverState.IconRightImage = null;
			this.save.OnIdleState.BorderColor = System.Drawing.Color.Silver;
			this.save.OnIdleState.BorderRadius = 1;
			this.save.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.OnIdleState.BorderThickness = 1;
			this.save.OnIdleState.FillColor = System.Drawing.Color.DimGray;
			this.save.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.save.OnIdleState.IconLeftImage = null;
			this.save.OnIdleState.IconRightImage = null;
			this.save.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
			this.save.OnPressedState.BorderRadius = 1;
			this.save.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.OnPressedState.BorderThickness = 1;
			this.save.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
			this.save.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.save.OnPressedState.IconLeftImage = null;
			this.save.OnPressedState.IconRightImage = null;
			this.save.Size = new System.Drawing.Size(196, 62);
			this.save.TabIndex = 10;
			this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.save.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.save.TextMarginLeft = 0;
			this.save.TextPadding = new System.Windows.Forms.Padding(0);
			this.save.UseDefaultRadiusAndThickness = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.name.Location = new System.Drawing.Point(812, 60);
			this.name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(136, 37);
			this.name.TabIndex = 0;
			this.name.Text = "Student:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(402, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 37);
			this.label2.TabIndex = 4;
			this.label2.Text = "Subject:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(1220, 60);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(252, 37);
			this.label4.TabIndex = 8;
			this.label4.Text = "Obtained Marks:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
			this.panel2.Controls.Add(this.bunifuDropdown2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.bunifuTextBox1);
			this.panel2.Controls.Add(this.bunifuDropdown3);
			this.panel2.Controls.Add(this.bunifuDropdown1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.name);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1600, 290);
			this.panel2.TabIndex = 8;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// bunifuDropdown2
			// 
			this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuDropdown2.BackgroundColor = System.Drawing.Color.White;
			this.bunifuDropdown2.BorderColor = System.Drawing.Color.Silver;
			this.bunifuDropdown2.BorderRadius = 1;
			this.bunifuDropdown2.Color = System.Drawing.Color.Silver;
			this.bunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.bunifuDropdown2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.bunifuDropdown2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bunifuDropdown2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.bunifuDropdown2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.bunifuDropdown2.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.bunifuDropdown2.DisplayMember = "Id";
			this.bunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.bunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.bunifuDropdown2.FillDropDown = true;
			this.bunifuDropdown2.FillIndicator = false;
			this.bunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bunifuDropdown2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bunifuDropdown2.ForeColor = System.Drawing.Color.Black;
			this.bunifuDropdown2.FormattingEnabled = true;
			this.bunifuDropdown2.Icon = null;
			this.bunifuDropdown2.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.bunifuDropdown2.IndicatorColor = System.Drawing.Color.DarkGray;
			this.bunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.bunifuDropdown2.IndicatorThickness = 2;
			this.bunifuDropdown2.IsDropdownOpened = false;
			this.bunifuDropdown2.ItemBackColor = System.Drawing.Color.White;
			this.bunifuDropdown2.ItemBorderColor = System.Drawing.Color.White;
			this.bunifuDropdown2.ItemForeColor = System.Drawing.Color.Black;
			this.bunifuDropdown2.ItemHeight = 20;
			this.bunifuDropdown2.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.bunifuDropdown2.ItemHighLightForeColor = System.Drawing.Color.White;
			this.bunifuDropdown2.ItemTopMargin = 3;
			this.bunifuDropdown2.Location = new System.Drawing.Point(32, 112);
			this.bunifuDropdown2.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuDropdown2.MaximumSize = new System.Drawing.Size(376, 0);
			this.bunifuDropdown2.Name = "bunifuDropdown2";
			this.bunifuDropdown2.Size = new System.Drawing.Size(340, 26);
			this.bunifuDropdown2.TabIndex = 22;
			this.bunifuDropdown2.Text = null;
			this.bunifuDropdown2.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.bunifuDropdown2.TextLeftMargin = 5;
			this.bunifuDropdown2.ValueMember = "Id";
			this.bunifuDropdown2.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown2_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(24, 60);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 37);
			this.label1.TabIndex = 21;
			this.label1.Text = "Class:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// bunifuTextBox1
			// 
			this.bunifuTextBox1.AcceptsReturn = false;
			this.bunifuTextBox1.AcceptsTab = false;
			this.bunifuTextBox1.AnimationSpeed = 200;
			this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.bunifuTextBox1.AutoSizeHeight = true;
			this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
			this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
			this.bunifuTextBox1.BorderRadius = 1;
			this.bunifuTextBox1.BorderThickness = 1;
			this.bunifuTextBox1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
			this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
			this.bunifuTextBox1.DefaultText = "";
			this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
			this.bunifuTextBox1.HideSelection = true;
			this.bunifuTextBox1.IconLeft = null;
			this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuTextBox1.IconPadding = 10;
			this.bunifuTextBox1.IconRight = null;
			this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuTextBox1.Lines = new string[0];
			this.bunifuTextBox1.Location = new System.Drawing.Point(1228, 104);
			this.bunifuTextBox1.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuTextBox1.MaxLength = 32767;
			this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(2, 2);
			this.bunifuTextBox1.Modified = false;
			this.bunifuTextBox1.Multiline = false;
			this.bunifuTextBox1.Name = "bunifuTextBox1";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.bunifuTextBox1.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.bunifuTextBox1.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.bunifuTextBox1.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.bunifuTextBox1.OnIdleState = stateProperties4;
			this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(6);
			this.bunifuTextBox1.PasswordChar = '\0';
			this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.bunifuTextBox1.PlaceholderText = "Enter text";
			this.bunifuTextBox1.ReadOnly = false;
			this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.bunifuTextBox1.SelectedText = "";
			this.bunifuTextBox1.SelectionLength = 0;
			this.bunifuTextBox1.SelectionStart = 0;
			this.bunifuTextBox1.ShortcutsEnabled = true;
			this.bunifuTextBox1.Size = new System.Drawing.Size(360, 58);
			this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.bunifuTextBox1.TabIndex = 20;
			this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bunifuTextBox1.TextMarginBottom = 0;
			this.bunifuTextBox1.TextMarginLeft = 3;
			this.bunifuTextBox1.TextMarginTop = 1;
			this.bunifuTextBox1.TextPlaceholder = "Enter text";
			this.bunifuTextBox1.UseSystemPasswordChar = false;
			this.bunifuTextBox1.WordWrap = true;
			// 
			// bunifuDropdown3
			// 
			this.bunifuDropdown3.BackColor = System.Drawing.Color.Transparent;
			this.bunifuDropdown3.BackgroundColor = System.Drawing.Color.White;
			this.bunifuDropdown3.BorderColor = System.Drawing.Color.Silver;
			this.bunifuDropdown3.BorderRadius = 1;
			this.bunifuDropdown3.Color = System.Drawing.Color.Silver;
			this.bunifuDropdown3.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.bunifuDropdown3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.bunifuDropdown3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bunifuDropdown3.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.bunifuDropdown3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.bunifuDropdown3.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.bunifuDropdown3.DisplayMember = "Id";
			this.bunifuDropdown3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.bunifuDropdown3.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.bunifuDropdown3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bunifuDropdown3.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.bunifuDropdown3.FillDropDown = true;
			this.bunifuDropdown3.FillIndicator = false;
			this.bunifuDropdown3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bunifuDropdown3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bunifuDropdown3.ForeColor = System.Drawing.Color.Black;
			this.bunifuDropdown3.FormattingEnabled = true;
			this.bunifuDropdown3.Icon = null;
			this.bunifuDropdown3.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.bunifuDropdown3.IndicatorColor = System.Drawing.Color.DarkGray;
			this.bunifuDropdown3.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.bunifuDropdown3.IndicatorThickness = 2;
			this.bunifuDropdown3.IsDropdownOpened = false;
			this.bunifuDropdown3.ItemBackColor = System.Drawing.Color.White;
			this.bunifuDropdown3.ItemBorderColor = System.Drawing.Color.White;
			this.bunifuDropdown3.ItemForeColor = System.Drawing.Color.Black;
			this.bunifuDropdown3.ItemHeight = 20;
			this.bunifuDropdown3.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.bunifuDropdown3.ItemHighLightForeColor = System.Drawing.Color.White;
			this.bunifuDropdown3.ItemTopMargin = 3;
			this.bunifuDropdown3.Location = new System.Drawing.Point(410, 112);
			this.bunifuDropdown3.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuDropdown3.MaximumSize = new System.Drawing.Size(376, 0);
			this.bunifuDropdown3.Name = "bunifuDropdown3";
			this.bunifuDropdown3.Size = new System.Drawing.Size(376, 26);
			this.bunifuDropdown3.TabIndex = 19;
			this.bunifuDropdown3.Text = null;
			this.bunifuDropdown3.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.bunifuDropdown3.TextLeftMargin = 5;
			this.bunifuDropdown3.ValueMember = "Id";
			this.bunifuDropdown3.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown3_SelectedIndexChanged);
			// 
			// bunifuDropdown1
			// 
			this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuDropdown1.BackgroundColor = System.Drawing.Color.White;
			this.bunifuDropdown1.BorderColor = System.Drawing.Color.Silver;
			this.bunifuDropdown1.BorderRadius = 1;
			this.bunifuDropdown1.Color = System.Drawing.Color.Silver;
			this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.bunifuDropdown1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.bunifuDropdown1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bunifuDropdown1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.bunifuDropdown1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.bunifuDropdown1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.bunifuDropdown1.DisplayMember = "Id";
			this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.bunifuDropdown1.FillDropDown = true;
			this.bunifuDropdown1.FillIndicator = false;
			this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bunifuDropdown1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
			this.bunifuDropdown1.FormattingEnabled = true;
			this.bunifuDropdown1.Icon = null;
			this.bunifuDropdown1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.DarkGray;
			this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.bunifuDropdown1.IndicatorThickness = 2;
			this.bunifuDropdown1.IsDropdownOpened = false;
			this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
			this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
			this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.Black;
			this.bunifuDropdown1.ItemHeight = 20;
			this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.bunifuDropdown1.ItemHighLightForeColor = System.Drawing.Color.White;
			this.bunifuDropdown1.ItemTopMargin = 3;
			this.bunifuDropdown1.Location = new System.Drawing.Point(820, 112);
			this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuDropdown1.MaximumSize = new System.Drawing.Size(376, 0);
			this.bunifuDropdown1.Name = "bunifuDropdown1";
			this.bunifuDropdown1.Size = new System.Drawing.Size(376, 26);
			this.bunifuDropdown1.TabIndex = 18;
			this.bunifuDropdown1.Text = null;
			this.bunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.bunifuDropdown1.TextLeftMargin = 5;
			this.bunifuDropdown1.ValueMember = "Id";
			this.bunifuDropdown1.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
			// 
			// StudentsData
			// 
			this.StudentsData.AllowCustomTheming = false;
			this.StudentsData.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.StudentsData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.StudentsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.StudentsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.StudentsData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.StudentsData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.StudentsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.StudentsData.ColumnHeadersHeight = 40;
			this.StudentsData.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.StudentsData.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.StudentsData.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.StudentsData.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			this.StudentsData.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.StudentsData.CurrentTheme.BackColor = System.Drawing.Color.DarkCyan;
			this.StudentsData.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
			this.StudentsData.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
			this.StudentsData.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			this.StudentsData.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.StudentsData.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			this.StudentsData.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.StudentsData.CurrentTheme.Name = null;
			this.StudentsData.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
			this.StudentsData.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.StudentsData.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.StudentsData.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			this.StudentsData.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.StudentsData.DefaultCellStyle = dataGridViewCellStyle3;
			this.StudentsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StudentsData.EnableHeadersVisualStyles = false;
			this.StudentsData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
			this.StudentsData.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
			this.StudentsData.HeaderBgColor = System.Drawing.Color.Empty;
			this.StudentsData.HeaderForeColor = System.Drawing.Color.White;
			this.StudentsData.Location = new System.Drawing.Point(0, 290);
			this.StudentsData.Margin = new System.Windows.Forms.Padding(6);
			this.StudentsData.Name = "StudentsData";
			this.StudentsData.ReadOnly = true;
			this.StudentsData.RowHeadersVisible = false;
			this.StudentsData.RowHeadersWidth = 82;
			this.StudentsData.RowTemplate.Height = 40;
			this.StudentsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.StudentsData.Size = new System.Drawing.Size(1600, 471);
			this.StudentsData.TabIndex = 9;
			this.StudentsData.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
			this.StudentsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsData_CellContentClick);
			// 
			// bunifuSnackbar1
			// 
			this.bunifuSnackbar1.AllowDragging = false;
			this.bunifuSnackbar1.AllowMultipleViews = true;
			this.bunifuSnackbar1.ClickToClose = true;
			this.bunifuSnackbar1.DoubleClickToClose = true;
			this.bunifuSnackbar1.DurationAfterIdle = 3000;
			this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
			this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
			this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
			this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
			this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
			this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
			this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
			this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
			this.bunifuSnackbar1.FadeCloseIcon = false;
			this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
			this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
			this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
			this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
			this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
			this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
			this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
			this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
			this.bunifuSnackbar1.Margin = 10;
			this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
			this.bunifuSnackbar1.MaximumViews = 7;
			this.bunifuSnackbar1.MessageRightMargin = 15;
			this.bunifuSnackbar1.MessageTopMargin = 0;
			this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
			this.bunifuSnackbar1.ShowBorders = false;
			this.bunifuSnackbar1.ShowCloseIcon = false;
			this.bunifuSnackbar1.ShowIcon = true;
			this.bunifuSnackbar1.ShowShadows = true;
			this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
			this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
			this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
			this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
			this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
			this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
			this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
			this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
			this.bunifuSnackbar1.ViewsMargin = 7;
			this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
			this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
			this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
			this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
			this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
			this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
			this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
			this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
			this.bunifuSnackbar1.ZoomCloseIcon = true;
			// 
			// rubricLevelBindingSource
			// 
			this.rubricLevelBindingSource.DataMember = "RubricLevel";
			// 
			// rubricLevelBindingSource1
			// 
			this.rubricLevelBindingSource1.DataMember = "RubricLevel";
			// 
			// assessmentComponentBindingSource
			// 
			this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
			// 
			// EvaluateStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1600, 865);
			this.Controls.Add(this.StudentsData);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "EvaluateStudent";
			this.Text = "EvaluateStudent";
			this.panel3.ResumeLayout(false);
			this.bunifuPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StudentsData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton save;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView StudentsData;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown3;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource1;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown2;
        private System.Windows.Forms.Label label1;
    }
}