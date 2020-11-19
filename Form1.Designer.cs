
namespace XRepeater
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
            this.TextPath = new System.Windows.Forms.TextBox();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonAddPt = new System.Windows.Forms.Button();
            this.ListPts = new System.Windows.Forms.ListView();
            this.ButtonJmpPt = new System.Windows.Forms.Button();
            this.ButtonNextSeg = new System.Windows.Forms.Button();
            this.LabelSeg = new System.Windows.Forms.Label();
            this.LabelCurTime = new System.Windows.Forms.Label();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextPath
            // 
            this.TextPath.Location = new System.Drawing.Point(12, 12);
            this.TextPath.Name = "TextPath";
            this.TextPath.Size = new System.Drawing.Size(433, 21);
            this.TextPath.TabIndex = 1;
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(451, 10);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoad.TabIndex = 2;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Location = new System.Drawing.Point(12, 39);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlay.TabIndex = 3;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonAddPt
            // 
            this.ButtonAddPt.Location = new System.Drawing.Point(93, 39);
            this.ButtonAddPt.Name = "ButtonAddPt";
            this.ButtonAddPt.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddPt.TabIndex = 4;
            this.ButtonAddPt.Text = "AddPt";
            this.ButtonAddPt.UseVisualStyleBackColor = true;
            this.ButtonAddPt.Click += new System.EventHandler(this.ButtonAddPt_Click);
            // 
            // ListPts
            // 
            this.ListPts.HideSelection = false;
            this.ListPts.Location = new System.Drawing.Point(12, 68);
            this.ListPts.MultiSelect = false;
            this.ListPts.Name = "ListPts";
            this.ListPts.Size = new System.Drawing.Size(514, 130);
            this.ListPts.TabIndex = 5;
            this.ListPts.UseCompatibleStateImageBehavior = false;
            this.ListPts.View = System.Windows.Forms.View.List;
            // 
            // ButtonJmpPt
            // 
            this.ButtonJmpPt.Location = new System.Drawing.Point(174, 40);
            this.ButtonJmpPt.Name = "ButtonJmpPt";
            this.ButtonJmpPt.Size = new System.Drawing.Size(75, 23);
            this.ButtonJmpPt.TabIndex = 6;
            this.ButtonJmpPt.Text = "JmpPt";
            this.ButtonJmpPt.UseVisualStyleBackColor = true;
            this.ButtonJmpPt.Click += new System.EventHandler(this.ButtonJmpPt_Click);
            // 
            // ButtonNextSeg
            // 
            this.ButtonNextSeg.Location = new System.Drawing.Point(255, 40);
            this.ButtonNextSeg.Name = "ButtonNextSeg";
            this.ButtonNextSeg.Size = new System.Drawing.Size(75, 23);
            this.ButtonNextSeg.TabIndex = 7;
            this.ButtonNextSeg.Text = "NextSeg";
            this.ButtonNextSeg.UseVisualStyleBackColor = true;
            this.ButtonNextSeg.Click += new System.EventHandler(this.ButtonNextSeg_Click);
            // 
            // LabelSeg
            // 
            this.LabelSeg.AutoSize = true;
            this.LabelSeg.Location = new System.Drawing.Point(339, 44);
            this.LabelSeg.Name = "LabelSeg";
            this.LabelSeg.Size = new System.Drawing.Size(65, 12);
            this.LabelSeg.TabIndex = 8;
            this.LabelSeg.Text = "CurSeg: -1";
            // 
            // LabelCurTime
            // 
            this.LabelCurTime.AutoSize = true;
            this.LabelCurTime.Location = new System.Drawing.Point(410, 44);
            this.LabelCurTime.Name = "LabelCurTime";
            this.LabelCurTime.Size = new System.Drawing.Size(71, 12);
            this.LabelCurTime.TabIndex = 9;
            this.LabelCurTime.Text = "CurTime: -1";
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(12, 204);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 10;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(93, 204);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemove.TabIndex = 11;
            this.ButtonRemove.Text = "RemovePt";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 233);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.LabelCurTime);
            this.Controls.Add(this.LabelSeg);
            this.Controls.Add(this.ButtonNextSeg);
            this.Controls.Add(this.ButtonJmpPt);
            this.Controls.Add(this.ListPts);
            this.Controls.Add(this.ButtonAddPt);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.TextPath);
            this.Name = "Form1";
            this.Text = "Repeater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextPath;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonAddPt;
        private System.Windows.Forms.ListView ListPts;
        private System.Windows.Forms.Button ButtonJmpPt;
        private System.Windows.Forms.Button ButtonNextSeg;
        private System.Windows.Forms.Label LabelSeg;
        private System.Windows.Forms.Label LabelCurTime;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonRemove;
    }
}

