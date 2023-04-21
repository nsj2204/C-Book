
namespace TodoApp.WindowFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIsDone = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.blnIsDone = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIsDone
            // 
            this.lblIsDone.AutoSize = true;
            this.lblIsDone.Location = new System.Drawing.Point(36, 39);
            this.lblIsDone.Name = "lblIsDone";
            this.lblIsDone.Size = new System.Drawing.Size(37, 12);
            this.lblIsDone.TabIndex = 0;
            this.lblIsDone.Text = "할 일:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(79, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(175, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // blnIsDone
            // 
            this.blnIsDone.AutoSize = true;
            this.blnIsDone.Location = new System.Drawing.Point(83, 72);
            this.blnIsDone.Name = "blnIsDone";
            this.blnIsDone.Size = new System.Drawing.Size(48, 16);
            this.blnIsDone.TabIndex = 2;
            this.blnIsDone.Text = "완료";
            this.blnIsDone.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "완 료 :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 51);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(38, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(299, 121);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 275);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blnIsDone);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblIsDone);
            this.Name = "Form1";
            this.Text = "할 일 목록";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsDone;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox blnIsDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

