namespace GameDisplay
{
    partial class MainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Rock = new System.Windows.Forms.Button();
            this.btn_Paper = new System.Windows.Forms.Button();
            this.btn_Scissors = new System.Windows.Forms.Button();
            this.lbl_PlayerScore = new System.Windows.Forms.Label();
            this.lbl_AIScore = new System.Windows.Forms.Label();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.lbl_AIName = new System.Windows.Forms.Label();
            this.lbl_vs = new System.Windows.Forms.Label();
            this.lbl_PlayerChoice = new System.Windows.Forms.Label();
            this.lbl_AIChoice = new System.Windows.Forms.Label();
            this.lbl_Brackets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Rock
            // 
            this.btn_Rock.Font = new System.Drawing.Font("Zekton", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Rock.Location = new System.Drawing.Point(63, 366);
            this.btn_Rock.Name = "btn_Rock";
            this.btn_Rock.Size = new System.Drawing.Size(210, 39);
            this.btn_Rock.TabIndex = 0;
            this.btn_Rock.Text = "Rock";
            this.btn_Rock.UseVisualStyleBackColor = true;
            // 
            // btn_Paper
            // 
            this.btn_Paper.Font = new System.Drawing.Font("Zekton", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Paper.Location = new System.Drawing.Point(294, 366);
            this.btn_Paper.Name = "btn_Paper";
            this.btn_Paper.Size = new System.Drawing.Size(210, 39);
            this.btn_Paper.TabIndex = 1;
            this.btn_Paper.Text = "Paper";
            this.btn_Paper.UseVisualStyleBackColor = true;
            // 
            // btn_Scissors
            // 
            this.btn_Scissors.Font = new System.Drawing.Font("Zekton", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Scissors.Location = new System.Drawing.Point(525, 366);
            this.btn_Scissors.Name = "btn_Scissors";
            this.btn_Scissors.Size = new System.Drawing.Size(210, 39);
            this.btn_Scissors.TabIndex = 2;
            this.btn_Scissors.Text = "Scissors";
            this.btn_Scissors.UseVisualStyleBackColor = true;
            // 
            // lbl_PlayerScore
            // 
            this.lbl_PlayerScore.AutoSize = true;
            this.lbl_PlayerScore.Font = new System.Drawing.Font("Zekton", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PlayerScore.Location = new System.Drawing.Point(364, 52);
            this.lbl_PlayerScore.Name = "lbl_PlayerScore";
            this.lbl_PlayerScore.Size = new System.Drawing.Size(25, 29);
            this.lbl_PlayerScore.TabIndex = 3;
            this.lbl_PlayerScore.Text = "0";
            // 
            // lbl_AIScore
            // 
            this.lbl_AIScore.AutoSize = true;
            this.lbl_AIScore.Font = new System.Drawing.Font("Zekton", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AIScore.Location = new System.Drawing.Point(455, 52);
            this.lbl_AIScore.Name = "lbl_AIScore";
            this.lbl_AIScore.Size = new System.Drawing.Size(25, 29);
            this.lbl_AIScore.TabIndex = 4;
            this.lbl_AIScore.Text = "0";
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Font = new System.Drawing.Font("Zekton", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PlayerName.Location = new System.Drawing.Point(114, 56);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(90, 34);
            this.lbl_PlayerName.TabIndex = 5;
            this.lbl_PlayerName.Text = "Player";
            // 
            // lbl_AIName
            // 
            this.lbl_AIName.AutoSize = true;
            this.lbl_AIName.Font = new System.Drawing.Font("Zekton", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AIName.Location = new System.Drawing.Point(629, 56);
            this.lbl_AIName.Name = "lbl_AIName";
            this.lbl_AIName.Size = new System.Drawing.Size(47, 34);
            this.lbl_AIName.TabIndex = 6;
            this.lbl_AIName.Text = "PC";
            // 
            // lbl_vs
            // 
            this.lbl_vs.AutoSize = true;
            this.lbl_vs.Font = new System.Drawing.Font("Zekton", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vs.Location = new System.Drawing.Point(411, 212);
            this.lbl_vs.Name = "lbl_vs";
            this.lbl_vs.Size = new System.Drawing.Size(33, 29);
            this.lbl_vs.TabIndex = 7;
            this.lbl_vs.Text = "vs";
            // 
            // lbl_PlayerChoice
            // 
            this.lbl_PlayerChoice.AutoSize = true;
            this.lbl_PlayerChoice.Font = new System.Drawing.Font("Zekton", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PlayerChoice.Location = new System.Drawing.Point(241, 212);
            this.lbl_PlayerChoice.Name = "lbl_PlayerChoice";
            this.lbl_PlayerChoice.Size = new System.Drawing.Size(126, 29);
            this.lbl_PlayerChoice.TabIndex = 8;
            this.lbl_PlayerChoice.Text = "Choice Player";
            // 
            // lbl_AIChoice
            // 
            this.lbl_AIChoice.AutoSize = true;
            this.lbl_AIChoice.Font = new System.Drawing.Font("Zekton", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AIChoice.Location = new System.Drawing.Point(484, 212);
            this.lbl_AIChoice.Name = "lbl_AIChoice";
            this.lbl_AIChoice.Size = new System.Drawing.Size(90, 29);
            this.lbl_AIChoice.TabIndex = 9;
            this.lbl_AIChoice.Text = "Choice AI";
            // 
            // lbl_Brackets
            // 
            this.lbl_Brackets.AutoSize = true;
            this.lbl_Brackets.Font = new System.Drawing.Font("Zekton", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Brackets.Location = new System.Drawing.Point(408, 35);
            this.lbl_Brackets.Name = "lbl_Brackets";
            this.lbl_Brackets.Size = new System.Drawing.Size(25, 46);
            this.lbl_Brackets.TabIndex = 10;
            this.lbl_Brackets.Text = ":";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Brackets);
            this.Controls.Add(this.lbl_AIChoice);
            this.Controls.Add(this.lbl_PlayerChoice);
            this.Controls.Add(this.lbl_vs);
            this.Controls.Add(this.lbl_AIName);
            this.Controls.Add(this.lbl_PlayerName);
            this.Controls.Add(this.lbl_AIScore);
            this.Controls.Add(this.lbl_PlayerScore);
            this.Controls.Add(this.btn_Scissors);
            this.Controls.Add(this.btn_Paper);
            this.Controls.Add(this.btn_Rock);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rock;
        private System.Windows.Forms.Button btn_Paper;
        private System.Windows.Forms.Button btn_Scissors;
        private System.Windows.Forms.Label lbl_PlayerScore;
        private System.Windows.Forms.Label lbl_AIScore;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.Label lbl_AIName;
        private System.Windows.Forms.Label lbl_vs;
        private System.Windows.Forms.Label lbl_PlayerChoice;
        private System.Windows.Forms.Label lbl_AIChoice;
        private System.Windows.Forms.Label lbl_Brackets;
    }
}

