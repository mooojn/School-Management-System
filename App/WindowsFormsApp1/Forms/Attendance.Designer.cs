namespace WindowsFormsApp1.Forms
{
	partial class Attendance
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.classBox = new Bunifu.UI.WinForms.BunifuDropdown();
			this.label1 = new System.Windows.Forms.Label();
			this.attendanceReport = new Bunifu.UI.WinForms.BunifuDataGridView();
			this.attendanceReportBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.message = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
			this.goBackBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.attendanceTable = new Bunifu.UI.WinForms.BunifuDataGridView();
			this.dateFilterBox = new Bunifu.UI.WinForms.BunifuDropdown();
			this.dateFilterLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.attendanceReport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.attendanceTable)).BeginInit();
			this.SuspendLayout();
			// 
			// classBox
			// 
			this.classBox.BackColor = System.Drawing.Color.Transparent;
			this.classBox.BackgroundColor = System.Drawing.Color.White;
			this.classBox.BorderColor = System.Drawing.Color.Silver;
			this.classBox.BorderRadius = 1;
			this.classBox.Color = System.Drawing.Color.Silver;
			this.classBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.classBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.classBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.classBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.classBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.classBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.classBox.DisplayMember = "Id";
			this.classBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.classBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.classBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.classBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.classBox.FillDropDown = true;
			this.classBox.FillIndicator = false;
			this.classBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.classBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.classBox.ForeColor = System.Drawing.Color.Black;
			this.classBox.FormattingEnabled = true;
			this.classBox.Icon = null;
			this.classBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.classBox.IndicatorColor = System.Drawing.Color.DarkGray;
			this.classBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.classBox.IndicatorThickness = 2;
			this.classBox.IsDropdownOpened = false;
			this.classBox.ItemBackColor = System.Drawing.Color.White;
			this.classBox.ItemBorderColor = System.Drawing.Color.White;
			this.classBox.ItemForeColor = System.Drawing.Color.Black;
			this.classBox.ItemHeight = 20;
			this.classBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.classBox.ItemHighLightForeColor = System.Drawing.Color.White;
			this.classBox.ItemTopMargin = 3;
			this.classBox.Location = new System.Drawing.Point(59, 150);
			this.classBox.Margin = new System.Windows.Forms.Padding(6);
			this.classBox.MaximumSize = new System.Drawing.Size(376, 0);
			this.classBox.Name = "classBox";
			this.classBox.Size = new System.Drawing.Size(340, 26);
			this.classBox.TabIndex = 24;
			this.classBox.Text = null;
			this.classBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.classBox.TextLeftMargin = 5;
			this.classBox.ValueMember = "Id";
			this.classBox.SelectedIndexChanged += new System.EventHandler(this.classBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(51, 98);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 37);
			this.label1.TabIndex = 23;
			this.label1.Text = "Class:";
			// 
			// attendanceReport
			// 
			this.attendanceReport.AllowCustomTheming = false;
			this.attendanceReport.AllowUserToAddRows = false;
			this.attendanceReport.AllowUserToDeleteRows = false;
			this.attendanceReport.AllowUserToOrderColumns = true;
			this.attendanceReport.AllowUserToResizeColumns = false;
			this.attendanceReport.AllowUserToResizeRows = false;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
			this.attendanceReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.attendanceReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.attendanceReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.attendanceReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.attendanceReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.attendanceReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.attendanceReport.ColumnHeadersHeight = 40;
			this.attendanceReport.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.attendanceReport.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.attendanceReport.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.attendanceReport.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			this.attendanceReport.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.attendanceReport.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
			this.attendanceReport.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
			this.attendanceReport.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
			this.attendanceReport.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			this.attendanceReport.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.attendanceReport.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			this.attendanceReport.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.attendanceReport.CurrentTheme.Name = null;
			this.attendanceReport.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
			this.attendanceReport.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.attendanceReport.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.attendanceReport.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			this.attendanceReport.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.attendanceReport.DefaultCellStyle = dataGridViewCellStyle15;
			this.attendanceReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.attendanceReport.EnableHeadersVisualStyles = false;
			this.attendanceReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
			this.attendanceReport.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
			this.attendanceReport.HeaderBgColor = System.Drawing.Color.Empty;
			this.attendanceReport.HeaderForeColor = System.Drawing.Color.White;
			this.attendanceReport.Location = new System.Drawing.Point(-2, 262);
			this.attendanceReport.Name = "attendanceReport";
			this.attendanceReport.ReadOnly = true;
			this.attendanceReport.RowHeadersVisible = false;
			this.attendanceReport.RowHeadersWidth = 82;
			this.attendanceReport.RowTemplate.Height = 40;
			this.attendanceReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.attendanceReport.ShowEditingIcon = false;
			this.attendanceReport.Size = new System.Drawing.Size(1499, 365);
			this.attendanceReport.TabIndex = 7;
			this.attendanceReport.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
			this.attendanceReport.Visible = false;
			this.attendanceReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceReport_CellContentClick);
			// 
			// attendanceReportBtn
			// 
			this.attendanceReportBtn.AllowAnimations = true;
			this.attendanceReportBtn.AllowMouseEffects = true;
			this.attendanceReportBtn.AllowToggling = false;
			this.attendanceReportBtn.AnimationSpeed = 200;
			this.attendanceReportBtn.AutoGenerateColors = false;
			this.attendanceReportBtn.AutoRoundBorders = false;
			this.attendanceReportBtn.AutoSizeLeftIcon = true;
			this.attendanceReportBtn.AutoSizeRightIcon = true;
			this.attendanceReportBtn.BackColor = System.Drawing.Color.Transparent;
			this.attendanceReportBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			this.attendanceReportBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attendanceReportBtn.BackgroundImage")));
			this.attendanceReportBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.attendanceReportBtn.ButtonText = "Attendance Report";
			this.attendanceReportBtn.ButtonTextMarginLeft = 0;
			this.attendanceReportBtn.ColorContrastOnClick = 45;
			this.attendanceReportBtn.ColorContrastOnHover = 45;
			this.attendanceReportBtn.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges5.BottomLeft = true;
			borderEdges5.BottomRight = true;
			borderEdges5.TopLeft = true;
			borderEdges5.TopRight = true;
			this.attendanceReportBtn.CustomizableEdges = borderEdges5;
			this.attendanceReportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.attendanceReportBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.attendanceReportBtn.DisabledFillColor = System.Drawing.Color.Empty;
			this.attendanceReportBtn.DisabledForecolor = System.Drawing.Color.Empty;
			this.attendanceReportBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
			this.attendanceReportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attendanceReportBtn.ForeColor = System.Drawing.Color.White;
			this.attendanceReportBtn.IconLeft = null;
			this.attendanceReportBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.attendanceReportBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.attendanceReportBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.attendanceReportBtn.IconMarginLeft = 11;
			this.attendanceReportBtn.IconPadding = 10;
			this.attendanceReportBtn.IconRight = null;
			this.attendanceReportBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.attendanceReportBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.attendanceReportBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.attendanceReportBtn.IconSize = 25;
			this.attendanceReportBtn.IdleBorderColor = System.Drawing.Color.Empty;
			this.attendanceReportBtn.IdleBorderRadius = 0;
			this.attendanceReportBtn.IdleBorderThickness = 0;
			this.attendanceReportBtn.IdleFillColor = System.Drawing.Color.Empty;
			this.attendanceReportBtn.IdleIconLeftImage = null;
			this.attendanceReportBtn.IdleIconRightImage = null;
			this.attendanceReportBtn.IndicateFocus = false;
			this.attendanceReportBtn.Location = new System.Drawing.Point(1105, 657);
			this.attendanceReportBtn.Margin = new System.Windows.Forms.Padding(6);
			this.attendanceReportBtn.Name = "attendanceReportBtn";
			this.attendanceReportBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.attendanceReportBtn.OnDisabledState.BorderRadius = 1;
			this.attendanceReportBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.attendanceReportBtn.OnDisabledState.BorderThickness = 1;
			this.attendanceReportBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.attendanceReportBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.attendanceReportBtn.OnDisabledState.IconLeftImage = null;
			this.attendanceReportBtn.OnDisabledState.IconRightImage = null;
			this.attendanceReportBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.attendanceReportBtn.onHoverState.BorderRadius = 1;
			this.attendanceReportBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.attendanceReportBtn.onHoverState.BorderThickness = 1;
			this.attendanceReportBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.attendanceReportBtn.onHoverState.ForeColor = System.Drawing.Color.White;
			this.attendanceReportBtn.onHoverState.IconLeftImage = null;
			this.attendanceReportBtn.onHoverState.IconRightImage = null;
			this.attendanceReportBtn.OnIdleState.BorderColor = System.Drawing.Color.Silver;
			this.attendanceReportBtn.OnIdleState.BorderRadius = 1;
			this.attendanceReportBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.attendanceReportBtn.OnIdleState.BorderThickness = 1;
			this.attendanceReportBtn.OnIdleState.FillColor = System.Drawing.Color.DimGray;
			this.attendanceReportBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.attendanceReportBtn.OnIdleState.IconLeftImage = null;
			this.attendanceReportBtn.OnIdleState.IconRightImage = null;
			this.attendanceReportBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
			this.attendanceReportBtn.OnPressedState.BorderRadius = 1;
			this.attendanceReportBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.attendanceReportBtn.OnPressedState.BorderThickness = 1;
			this.attendanceReportBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
			this.attendanceReportBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.attendanceReportBtn.OnPressedState.IconLeftImage = null;
			this.attendanceReportBtn.OnPressedState.IconRightImage = null;
			this.attendanceReportBtn.Size = new System.Drawing.Size(293, 74);
			this.attendanceReportBtn.TabIndex = 25;
			this.attendanceReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.attendanceReportBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.attendanceReportBtn.TextMarginLeft = 0;
			this.attendanceReportBtn.TextPadding = new System.Windows.Forms.Padding(0);
			this.attendanceReportBtn.UseDefaultRadiusAndThickness = true;
			this.attendanceReportBtn.Click += new System.EventHandler(this.attendanceReportBtn_Click_2);
			// 
			// message
			// 
			this.message.AllowDragging = false;
			this.message.AllowMultipleViews = true;
			this.message.ClickToClose = true;
			this.message.DoubleClickToClose = true;
			this.message.DurationAfterIdle = 3000;
			this.message.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.message.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.message.ErrorOptions.ActionBorderRadius = 1;
			this.message.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.message.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
			this.message.ErrorOptions.BackColor = System.Drawing.Color.White;
			this.message.ErrorOptions.BorderColor = System.Drawing.Color.White;
			this.message.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
			this.message.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.message.ErrorOptions.ForeColor = System.Drawing.Color.Black;
			this.message.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
			this.message.ErrorOptions.IconLeftMargin = 12;
			this.message.FadeCloseIcon = false;
			this.message.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
			this.message.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.message.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.message.InformationOptions.ActionBorderRadius = 1;
			this.message.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.message.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
			this.message.InformationOptions.BackColor = System.Drawing.Color.White;
			this.message.InformationOptions.BorderColor = System.Drawing.Color.White;
			this.message.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
			this.message.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.message.InformationOptions.ForeColor = System.Drawing.Color.Black;
			this.message.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
			this.message.InformationOptions.IconLeftMargin = 12;
			this.message.Margin = 10;
			this.message.MaximumSize = new System.Drawing.Size(0, 0);
			this.message.MaximumViews = 7;
			this.message.MessageRightMargin = 15;
			this.message.MessageTopMargin = 0;
			this.message.MinimumSize = new System.Drawing.Size(0, 0);
			this.message.ShowBorders = false;
			this.message.ShowCloseIcon = false;
			this.message.ShowIcon = true;
			this.message.ShowShadows = true;
			this.message.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.message.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.message.SuccessOptions.ActionBorderRadius = 1;
			this.message.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.message.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
			this.message.SuccessOptions.BackColor = System.Drawing.Color.White;
			this.message.SuccessOptions.BorderColor = System.Drawing.Color.White;
			this.message.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
			this.message.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.message.SuccessOptions.ForeColor = System.Drawing.Color.Black;
			this.message.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
			this.message.SuccessOptions.IconLeftMargin = 12;
			this.message.ViewsMargin = 7;
			this.message.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.message.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.message.WarningOptions.ActionBorderRadius = 1;
			this.message.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.message.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
			this.message.WarningOptions.BackColor = System.Drawing.Color.White;
			this.message.WarningOptions.BorderColor = System.Drawing.Color.White;
			this.message.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
			this.message.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.message.WarningOptions.ForeColor = System.Drawing.Color.Black;
			this.message.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
			this.message.WarningOptions.IconLeftMargin = 12;
			this.message.ZoomCloseIcon = true;
			// 
			// goBackBtn
			// 
			this.goBackBtn.AllowAnimations = true;
			this.goBackBtn.AllowMouseEffects = true;
			this.goBackBtn.AllowToggling = false;
			this.goBackBtn.AnimationSpeed = 200;
			this.goBackBtn.AutoGenerateColors = false;
			this.goBackBtn.AutoRoundBorders = false;
			this.goBackBtn.AutoSizeLeftIcon = true;
			this.goBackBtn.AutoSizeRightIcon = true;
			this.goBackBtn.BackColor = System.Drawing.Color.Transparent;
			this.goBackBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			this.goBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goBackBtn.BackgroundImage")));
			this.goBackBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.goBackBtn.ButtonText = "Go Back";
			this.goBackBtn.ButtonTextMarginLeft = 0;
			this.goBackBtn.ColorContrastOnClick = 45;
			this.goBackBtn.ColorContrastOnHover = 45;
			this.goBackBtn.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges6.BottomLeft = true;
			borderEdges6.BottomRight = true;
			borderEdges6.TopLeft = true;
			borderEdges6.TopRight = true;
			this.goBackBtn.CustomizableEdges = borderEdges6;
			this.goBackBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.goBackBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.goBackBtn.DisabledFillColor = System.Drawing.Color.Empty;
			this.goBackBtn.DisabledForecolor = System.Drawing.Color.Empty;
			this.goBackBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
			this.goBackBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.goBackBtn.ForeColor = System.Drawing.Color.White;
			this.goBackBtn.IconLeft = null;
			this.goBackBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.goBackBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.goBackBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.goBackBtn.IconMarginLeft = 11;
			this.goBackBtn.IconPadding = 10;
			this.goBackBtn.IconRight = null;
			this.goBackBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.goBackBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.goBackBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.goBackBtn.IconSize = 25;
			this.goBackBtn.IdleBorderColor = System.Drawing.Color.Empty;
			this.goBackBtn.IdleBorderRadius = 0;
			this.goBackBtn.IdleBorderThickness = 0;
			this.goBackBtn.IdleFillColor = System.Drawing.Color.Empty;
			this.goBackBtn.IdleIconLeftImage = null;
			this.goBackBtn.IdleIconRightImage = null;
			this.goBackBtn.IndicateFocus = false;
			this.goBackBtn.Location = new System.Drawing.Point(1105, 657);
			this.goBackBtn.Margin = new System.Windows.Forms.Padding(6);
			this.goBackBtn.Name = "goBackBtn";
			this.goBackBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.goBackBtn.OnDisabledState.BorderRadius = 1;
			this.goBackBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.goBackBtn.OnDisabledState.BorderThickness = 1;
			this.goBackBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.goBackBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.goBackBtn.OnDisabledState.IconLeftImage = null;
			this.goBackBtn.OnDisabledState.IconRightImage = null;
			this.goBackBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.goBackBtn.onHoverState.BorderRadius = 1;
			this.goBackBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.goBackBtn.onHoverState.BorderThickness = 1;
			this.goBackBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.goBackBtn.onHoverState.ForeColor = System.Drawing.Color.White;
			this.goBackBtn.onHoverState.IconLeftImage = null;
			this.goBackBtn.onHoverState.IconRightImage = null;
			this.goBackBtn.OnIdleState.BorderColor = System.Drawing.Color.Silver;
			this.goBackBtn.OnIdleState.BorderRadius = 1;
			this.goBackBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.goBackBtn.OnIdleState.BorderThickness = 1;
			this.goBackBtn.OnIdleState.FillColor = System.Drawing.Color.DimGray;
			this.goBackBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.goBackBtn.OnIdleState.IconLeftImage = null;
			this.goBackBtn.OnIdleState.IconRightImage = null;
			this.goBackBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
			this.goBackBtn.OnPressedState.BorderRadius = 1;
			this.goBackBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.goBackBtn.OnPressedState.BorderThickness = 1;
			this.goBackBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
			this.goBackBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.goBackBtn.OnPressedState.IconLeftImage = null;
			this.goBackBtn.OnPressedState.IconRightImage = null;
			this.goBackBtn.Size = new System.Drawing.Size(293, 74);
			this.goBackBtn.TabIndex = 26;
			this.goBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.goBackBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.goBackBtn.TextMarginLeft = 0;
			this.goBackBtn.TextPadding = new System.Windows.Forms.Padding(0);
			this.goBackBtn.UseDefaultRadiusAndThickness = true;
			this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
			// 
			// attendanceTable
			// 
			this.attendanceTable.AllowCustomTheming = false;
			this.attendanceTable.AllowUserToAddRows = false;
			this.attendanceTable.AllowUserToDeleteRows = false;
			this.attendanceTable.AllowUserToOrderColumns = true;
			this.attendanceTable.AllowUserToResizeColumns = false;
			this.attendanceTable.AllowUserToResizeRows = false;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
			this.attendanceTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.attendanceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.attendanceTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.attendanceTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.attendanceTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.attendanceTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.attendanceTable.ColumnHeadersHeight = 40;
			this.attendanceTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.attendanceTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.attendanceTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.attendanceTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			this.attendanceTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.attendanceTable.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
			this.attendanceTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
			this.attendanceTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
			this.attendanceTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			this.attendanceTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.attendanceTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			this.attendanceTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.attendanceTable.CurrentTheme.Name = null;
			this.attendanceTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
			this.attendanceTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.attendanceTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.attendanceTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			this.attendanceTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.attendanceTable.DefaultCellStyle = dataGridViewCellStyle18;
			this.attendanceTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.attendanceTable.EnableHeadersVisualStyles = false;
			this.attendanceTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
			this.attendanceTable.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
			this.attendanceTable.HeaderBgColor = System.Drawing.Color.Empty;
			this.attendanceTable.HeaderForeColor = System.Drawing.Color.White;
			this.attendanceTable.Location = new System.Drawing.Point(3, 262);
			this.attendanceTable.Name = "attendanceTable";
			this.attendanceTable.ReadOnly = true;
			this.attendanceTable.RowHeadersVisible = false;
			this.attendanceTable.RowHeadersWidth = 82;
			this.attendanceTable.RowTemplate.Height = 40;
			this.attendanceTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.attendanceTable.ShowEditingIcon = false;
			this.attendanceTable.Size = new System.Drawing.Size(1499, 365);
			this.attendanceTable.TabIndex = 14;
			this.attendanceTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
			// 
			// dateFilterBox
			// 
			this.dateFilterBox.BackColor = System.Drawing.Color.Transparent;
			this.dateFilterBox.BackgroundColor = System.Drawing.Color.White;
			this.dateFilterBox.BorderColor = System.Drawing.Color.Silver;
			this.dateFilterBox.BorderRadius = 1;
			this.dateFilterBox.Color = System.Drawing.Color.Silver;
			this.dateFilterBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.dateFilterBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dateFilterBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.dateFilterBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dateFilterBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.dateFilterBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.dateFilterBox.DisplayMember = "Id";
			this.dateFilterBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.dateFilterBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.dateFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dateFilterBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.dateFilterBox.FillDropDown = true;
			this.dateFilterBox.FillIndicator = false;
			this.dateFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dateFilterBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dateFilterBox.ForeColor = System.Drawing.Color.Black;
			this.dateFilterBox.FormattingEnabled = true;
			this.dateFilterBox.Icon = null;
			this.dateFilterBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.dateFilterBox.IndicatorColor = System.Drawing.Color.DarkGray;
			this.dateFilterBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.dateFilterBox.IndicatorThickness = 2;
			this.dateFilterBox.IsDropdownOpened = false;
			this.dateFilterBox.ItemBackColor = System.Drawing.Color.White;
			this.dateFilterBox.ItemBorderColor = System.Drawing.Color.White;
			this.dateFilterBox.ItemForeColor = System.Drawing.Color.Black;
			this.dateFilterBox.ItemHeight = 20;
			this.dateFilterBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.dateFilterBox.ItemHighLightForeColor = System.Drawing.Color.White;
			this.dateFilterBox.ItemTopMargin = 3;
			this.dateFilterBox.Location = new System.Drawing.Point(654, 150);
			this.dateFilterBox.Margin = new System.Windows.Forms.Padding(6);
			this.dateFilterBox.MaximumSize = new System.Drawing.Size(376, 0);
			this.dateFilterBox.Name = "dateFilterBox";
			this.dateFilterBox.Size = new System.Drawing.Size(340, 26);
			this.dateFilterBox.TabIndex = 28;
			this.dateFilterBox.Text = null;
			this.dateFilterBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.dateFilterBox.TextLeftMargin = 5;
			this.dateFilterBox.ValueMember = "Id";
			this.dateFilterBox.SelectedIndexChanged += new System.EventHandler(this.dateFilterBox_SelectedIndexChanged);
			// 
			// dateFilterLabel
			// 
			this.dateFilterLabel.AutoSize = true;
			this.dateFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateFilterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.dateFilterLabel.Location = new System.Drawing.Point(646, 98);
			this.dateFilterLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.dateFilterLabel.Name = "dateFilterLabel";
			this.dateFilterLabel.Size = new System.Drawing.Size(93, 37);
			this.dateFilterLabel.TabIndex = 27;
			this.dateFilterLabel.Text = "Date:";
			// 
			// Attendance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
			this.ClientSize = new System.Drawing.Size(1564, 871);
			this.Controls.Add(this.dateFilterBox);
			this.Controls.Add(this.dateFilterLabel);
			this.Controls.Add(this.goBackBtn);
			this.Controls.Add(this.attendanceReportBtn);
			this.Controls.Add(this.classBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.attendanceTable);
			this.Controls.Add(this.attendanceReport);
			this.Name = "Attendance";
			this.Text = "Attendance";
			this.Load += new System.EventHandler(this.Attendance_Load);
			((System.ComponentModel.ISupportInitialize)(this.attendanceReport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.attendanceTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Bunifu.UI.WinForms.BunifuDropdown classBox;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuDataGridView attendanceReport;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton attendanceReportBtn;
		private Bunifu.UI.WinForms.BunifuSnackbar message;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton goBackBtn;
		private Bunifu.UI.WinForms.BunifuDataGridView attendanceTable;
		private Bunifu.UI.WinForms.BunifuDropdown dateFilterBox;
		private System.Windows.Forms.Label dateFilterLabel;
	}
}