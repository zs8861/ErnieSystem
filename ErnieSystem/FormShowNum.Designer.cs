namespace ErnieSystem
{
    partial class FormShowNum
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_NewTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_OK = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(-2, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "每屏显示人数:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBoxX_NewTitle
            // 
            // 
            // 
            // 
            this.textBoxX_NewTitle.Border.Class = "TextBoxBorder";
            this.textBoxX_NewTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_NewTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxX_NewTitle.Location = new System.Drawing.Point(100, 29);
            this.textBoxX_NewTitle.Name = "textBoxX_NewTitle";
            this.textBoxX_NewTitle.Size = new System.Drawing.Size(162, 23);
            this.textBoxX_NewTitle.TabIndex = 2;
            this.textBoxX_NewTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonX_Cancel
            // 
            this.buttonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX_Cancel.Location = new System.Drawing.Point(154, 70);
            this.buttonX_Cancel.Name = "buttonX_Cancel";
            this.buttonX_Cancel.Size = new System.Drawing.Size(78, 23);
            this.buttonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Cancel.TabIndex = 15;
            this.buttonX_Cancel.Text = "取消";
            this.buttonX_Cancel.Click += new System.EventHandler(this.buttonX_Cancel_Click);
            // 
            // buttonX_OK
            // 
            this.buttonX_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX_OK.Location = new System.Drawing.Point(70, 70);
            this.buttonX_OK.Name = "buttonX_OK";
            this.buttonX_OK.Size = new System.Drawing.Size(78, 23);
            this.buttonX_OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_OK.TabIndex = 14;
            this.buttonX_OK.Text = "确认";
            this.buttonX_OK.Click += new System.EventHandler(this.buttonX_OK_Click);
            // 
            // FormShowNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 113);
            this.Controls.Add(this.buttonX_Cancel);
            this.Controls.Add(this.buttonX_OK);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX_NewTitle);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormShowNum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改显示人数";
            this.Load += new System.EventHandler(this.FormNewTitle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_NewTitle;
        private DevComponents.DotNetBar.ButtonX buttonX_Cancel;
        private DevComponents.DotNetBar.ButtonX buttonX_OK;
    }
}