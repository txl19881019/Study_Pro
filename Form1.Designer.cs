
namespace WindowsFormsApp1
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.身体属性 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.五行属性 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.基础属性 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.身体属性.SuspendLayout();
            this.五行属性.SuspendLayout();
            this.基础属性.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 447);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.身体属性);
            this.tabPage1.Controls.Add(this.五行属性);
            this.tabPage1.Controls.Add(this.基础属性);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人物";
            // 
            // 身体属性
            // 
            this.身体属性.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.身体属性.Controls.Add(this.label2);
            this.身体属性.Location = new System.Drawing.Point(272, 14);
            this.身体属性.Name = "身体属性";
            this.身体属性.Size = new System.Drawing.Size(245, 391);
            this.身体属性.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(95, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "身体属性";
            // 
            // 五行属性
            // 
            this.五行属性.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.五行属性.Controls.Add(this.label3);
            this.五行属性.Location = new System.Drawing.Point(525, 14);
            this.五行属性.Name = "五行属性";
            this.五行属性.Size = new System.Drawing.Size(245, 391);
            this.五行属性.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(100, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "五行属性";
            // 
            // 基础属性
            // 
            this.基础属性.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.基础属性.Controls.Add(this.label1);
            this.基础属性.Location = new System.Drawing.Point(15, 14);
            this.基础属性.Name = "基础属性";
            this.基础属性.Size = new System.Drawing.Size(245, 391);
            this.基础属性.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(88, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "基础属性";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "背包";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(786, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "仓库";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "窗口";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.身体属性.ResumeLayout(false);
            this.身体属性.PerformLayout();
            this.五行属性.ResumeLayout(false);
            this.五行属性.PerformLayout();
            this.基础属性.ResumeLayout(false);
            this.基础属性.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;  //人物
        private System.Windows.Forms.TabPage tabPage2;  //背包
        private System.Windows.Forms.TabPage tabPage3; //仓库
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel 基础属性;
        private System.Windows.Forms.Panel 身体属性;
        private System.Windows.Forms.Panel 五行属性;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

