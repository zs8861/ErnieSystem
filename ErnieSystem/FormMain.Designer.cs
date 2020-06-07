namespace ErnieSystem
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxX_SpecialAwardNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_FirstPriceNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_SecondPriceNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_ThirdPriceNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.buttonX_InportNameList = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_StartErnie = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxX_ReverseOrder = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX_ModifyBackGround = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_ModifyEnieNum = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_ModifyTitle = new DevComponents.DotNetBar.ButtonX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX_SpecialAwardNum
            // 
            // 
            // 
            // 
            this.textBoxX_SpecialAwardNum.Border.Class = "TextBoxBorder";
            this.textBoxX_SpecialAwardNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_SpecialAwardNum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlighter1.SetHighlightOnFocus(this.textBoxX_SpecialAwardNum, true);
            this.textBoxX_SpecialAwardNum.Location = new System.Drawing.Point(112, 52);
            this.textBoxX_SpecialAwardNum.Name = "textBoxX_SpecialAwardNum";
            this.textBoxX_SpecialAwardNum.Size = new System.Drawing.Size(180, 23);
            this.textBoxX_SpecialAwardNum.TabIndex = 0;
            this.textBoxX_SpecialAwardNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_SpecialAwardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_SpecialAwardNum_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(55, 48);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "特等奖";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(55, 77);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "一等奖";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(55, 106);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(44, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "二等奖";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(55, 135);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(44, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "三等奖";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBoxX_FirstPriceNum
            // 
            // 
            // 
            // 
            this.textBoxX_FirstPriceNum.Border.Class = "TextBoxBorder";
            this.textBoxX_FirstPriceNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_FirstPriceNum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlighter1.SetHighlightOnFocus(this.textBoxX_FirstPriceNum, true);
            this.textBoxX_FirstPriceNum.Location = new System.Drawing.Point(112, 79);
            this.textBoxX_FirstPriceNum.Name = "textBoxX_FirstPriceNum";
            this.textBoxX_FirstPriceNum.Size = new System.Drawing.Size(180, 23);
            this.textBoxX_FirstPriceNum.TabIndex = 5;
            this.textBoxX_FirstPriceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_FirstPriceNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_FirstPriceNum_KeyPress);
            // 
            // textBoxX_SecondPriceNum
            // 
            // 
            // 
            // 
            this.textBoxX_SecondPriceNum.Border.Class = "TextBoxBorder";
            this.textBoxX_SecondPriceNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_SecondPriceNum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlighter1.SetHighlightOnFocus(this.textBoxX_SecondPriceNum, true);
            this.textBoxX_SecondPriceNum.Location = new System.Drawing.Point(112, 106);
            this.textBoxX_SecondPriceNum.Name = "textBoxX_SecondPriceNum";
            this.textBoxX_SecondPriceNum.Size = new System.Drawing.Size(180, 23);
            this.textBoxX_SecondPriceNum.TabIndex = 6;
            this.textBoxX_SecondPriceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_SecondPriceNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_SecondPriceNum_KeyPress);
            // 
            // textBoxX_ThirdPriceNum
            // 
            // 
            // 
            // 
            this.textBoxX_ThirdPriceNum.Border.Class = "TextBoxBorder";
            this.textBoxX_ThirdPriceNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_ThirdPriceNum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlighter1.SetHighlightOnFocus(this.textBoxX_ThirdPriceNum, true);
            this.textBoxX_ThirdPriceNum.Location = new System.Drawing.Point(112, 133);
            this.textBoxX_ThirdPriceNum.Name = "textBoxX_ThirdPriceNum";
            this.textBoxX_ThirdPriceNum.Size = new System.Drawing.Size(180, 23);
            this.textBoxX_ThirdPriceNum.TabIndex = 7;
            this.textBoxX_ThirdPriceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_ThirdPriceNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_ThirdPriceNum_KeyPress);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(309, 50);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(21, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "名";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(309, 77);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(21, 23);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "名";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(309, 135);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(21, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "名";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(309, 105);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(21, 23);
            this.labelX8.TabIndex = 11;
            this.labelX8.Text = "名";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // buttonX_InportNameList
            // 
            this.buttonX_InportNameList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_InportNameList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_InportNameList.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX_InportNameList.Location = new System.Drawing.Point(135, 187);
            this.buttonX_InportNameList.Name = "buttonX_InportNameList";
            this.buttonX_InportNameList.Size = new System.Drawing.Size(100, 23);
            this.buttonX_InportNameList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_InportNameList.TabIndex = 12;
            this.buttonX_InportNameList.Text = "导入抽奖名单";
            this.buttonX_InportNameList.Click += new System.EventHandler(this.buttonX_InportNameList_Click);
            // 
            // buttonX_StartErnie
            // 
            this.buttonX_StartErnie.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_StartErnie.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_StartErnie.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX_StartErnie.Location = new System.Drawing.Point(226, 152);
            this.buttonX_StartErnie.Name = "buttonX_StartErnie";
            this.buttonX_StartErnie.Size = new System.Drawing.Size(100, 23);
            this.buttonX_StartErnie.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_StartErnie.TabIndex = 13;
            this.buttonX_StartErnie.Text = "开始抽奖";
            this.buttonX_StartErnie.Click += new System.EventHandler(this.buttonX_StartErnie_Click);
            // 
            // checkBoxX_ReverseOrder
            // 
            // 
            // 
            // 
            this.checkBoxX_ReverseOrder.BackgroundStyle.Class = "";
            this.checkBoxX_ReverseOrder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_ReverseOrder.Checked = true;
            this.checkBoxX_ReverseOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_ReverseOrder.CheckValue = "Y";
            this.checkBoxX_ReverseOrder.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxX_ReverseOrder.Location = new System.Drawing.Point(14, 127);
            this.checkBoxX_ReverseOrder.Name = "checkBoxX_ReverseOrder";
            this.checkBoxX_ReverseOrder.Size = new System.Drawing.Size(82, 23);
            this.checkBoxX_ReverseOrder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_ReverseOrder.TabIndex = 14;
            this.checkBoxX_ReverseOrder.Text = "倒序抽奖";
            this.checkBoxX_ReverseOrder.Visible = false;
            this.checkBoxX_ReverseOrder.CheckedChanged += new System.EventHandler(this.checkBoxX_ReverseOrder_CheckedChanged);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonX_ModifyBackGround);
            this.groupPanel1.Controls.Add(this.buttonX_ModifyEnieNum);
            this.groupPanel1.Controls.Add(this.buttonX_ModifyTitle);
            this.groupPanel1.Controls.Add(this.buttonX_StartErnie);
            this.groupPanel1.Controls.Add(this.checkBoxX_ReverseOrder);
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(367, 261);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 15;
            this.groupPanel1.Text = "摇奖设置";
            // 
            // buttonX_ModifyBackGround
            // 
            this.buttonX_ModifyBackGround.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ModifyBackGround.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ModifyBackGround.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX_ModifyBackGround.Location = new System.Drawing.Point(120, 186);
            this.buttonX_ModifyBackGround.Name = "buttonX_ModifyBackGround";
            this.buttonX_ModifyBackGround.Size = new System.Drawing.Size(100, 23);
            this.buttonX_ModifyBackGround.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ModifyBackGround.TabIndex = 17;
            this.buttonX_ModifyBackGround.Text = "修改摇奖背景";
            this.buttonX_ModifyBackGround.Click += new System.EventHandler(this.buttonX_ModifyBackGround_Click);
            // 
            // buttonX_ModifyEnieNum
            // 
            this.buttonX_ModifyEnieNum.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ModifyEnieNum.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ModifyEnieNum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX_ModifyEnieNum.Location = new System.Drawing.Point(14, 186);
            this.buttonX_ModifyEnieNum.Name = "buttonX_ModifyEnieNum";
            this.buttonX_ModifyEnieNum.Size = new System.Drawing.Size(100, 23);
            this.buttonX_ModifyEnieNum.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ModifyEnieNum.TabIndex = 16;
            this.buttonX_ModifyEnieNum.Text = "修改显示人数";
            this.buttonX_ModifyEnieNum.Click += new System.EventHandler(this.buttonX_ModifyEnieNum_Click);
            // 
            // buttonX_ModifyTitle
            // 
            this.buttonX_ModifyTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_ModifyTitle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_ModifyTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX_ModifyTitle.Location = new System.Drawing.Point(14, 152);
            this.buttonX_ModifyTitle.Name = "buttonX_ModifyTitle";
            this.buttonX_ModifyTitle.Size = new System.Drawing.Size(100, 23);
            this.buttonX_ModifyTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_ModifyTitle.TabIndex = 15;
            this.buttonX_ModifyTitle.Text = "修改标题";
            this.buttonX_ModifyTitle.Click += new System.EventHandler(this.buttonX_ModifyTitle_Click);
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 285);
            this.Controls.Add(this.buttonX_InportNameList);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.textBoxX_ThirdPriceNum);
            this.Controls.Add(this.textBoxX_SecondPriceNum);
            this.Controls.Add(this.textBoxX_FirstPriceNum);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX_SpecialAwardNum);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B站摇奖系统 V1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_SpecialAwardNum;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_FirstPriceNum;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_SecondPriceNum;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_ThirdPriceNum;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX buttonX_InportNameList;
        private DevComponents.DotNetBar.ButtonX buttonX_StartErnie;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_ReverseOrder;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonX_ModifyTitle;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.ButtonX buttonX_ModifyBackGround;
        private DevComponents.DotNetBar.ButtonX buttonX_ModifyEnieNum;
    }
}

