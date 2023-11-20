namespace Cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTxtComment = new System.Windows.Forms.RichTextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnC = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.btnShowDialog);
            this.gbUser.Controls.Add(this.btnShow);
            this.gbUser.Controls.Add(this.btnC);
            this.gbUser.Controls.Add(this.btnSave);
            this.gbUser.Controls.Add(this.lblK);
            this.gbUser.Controls.Add(this.richTxtComment);
            this.gbUser.Controls.Add(this.btnChooseImage);
            this.gbUser.Controls.Add(this.pbAvatar);
            this.gbUser.Controls.Add(this.txtN);
            this.gbUser.Controls.Add(this.lblN);
            this.gbUser.Location = new System.Drawing.Point(13, 22);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(496, 262);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Потребител";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(237, 19);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(29, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Име";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(240, 35);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(13, 290);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(125, 50);
            this.btnHello.TabIndex = 1;
            this.btnHello.Text = "Здрасти!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(-1, 19);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(200, 251);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAvatar.TabIndex = 2;
            this.pbAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(48, 205);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(99, 23);
            this.btnChooseImage.TabIndex = 3;
            this.btnChooseImage.Text = "Избери ...";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.Filter = "Image Files(*.JPG;*.GIF)|*.JPG;*.GIF| All files (*.*)|*.*";
            // 
            // richTxtComment
            // 
            this.richTxtComment.Location = new System.Drawing.Point(240, 75);
            this.richTxtComment.Name = "richTxtComment";
            this.richTxtComment.Size = new System.Drawing.Size(135, 59);
            this.richTxtComment.TabIndex = 4;
            this.richTxtComment.Text = "";
            this.richTxtComment.TextChanged += new System.EventHandler(this.richTxtComment_TextChanged);
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(237, 58);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(60, 13);
            this.lblK.TabIndex = 5;
            this.lblK.Text = "Коментар:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(316, 179);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(85, 34);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "Изчисти";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(381, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(109, 50);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show second Form";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(381, 75);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(109, 50);
            this.btnShowDialog.TabIndex = 9;
            this.btnShowDialog.Text = "Show Dialog Second Form";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 352);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.gbUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.RichTextBox richTxtComment;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

